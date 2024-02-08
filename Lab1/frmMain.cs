using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab1
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            if (!(Regex.IsMatch(tbA.Text, @"^\d+$") && Regex.IsMatch(tbB.Text, @"^\d+$") && Regex.IsMatch(tbC.Text, @"^\d+$")))
            {
                MessageBox.Show($"One ore more of the entered values is invalid!{Environment.NewLine}Please, make sure you have entered only positive digits (0 and any letters are not allowed).", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (CheckText4Zero(ref tbA) || CheckText4Zero(ref tbB) || CheckText4Zero(ref tbC))
                {
                    MessageBox.Show($"One ore more of the entered values is equal to 0!{Environment.NewLine}Please, enter only positive numbers", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    CalculateTriangle();
                }
            }
        }
        private bool CheckText4Zero(ref TextBox tbx)
        {
            bool flg = false;
            if (tbx.Text == "0" || String.Concat(tbx.Text.GroupBy(c => c).SelectMany(g => $"{g.Key}")) == "0")
            {
                flg = true;
            }
            return flg;
        }
        private string Check4Isosceles(List<int> triangleSides)
        {
            bool flg = false;
            string res = "";
            foreach (var t in triangleSides)
            {
                var tmp = new List<int>(triangleSides);
                tmp.Remove(t);
                foreach (var tt in tmp)
                {
                    if (tt == t)
                    {
                        res = "Рівнобедрений." + Environment.NewLine + Environment.NewLine + $"Серед сторін даного трикутника є дві, що дорівнюють {tt}.";
                        break;
                    }
                }
                if (flg)
                {
                    break;
                }
            }
            return res;
        }
        private string Check4RightOrObtuse(List<int> triangleSides)
        {
            string res = "";
            int max = triangleSides.Max();
            var tmp = new List<int>(triangleSides);
            tmp.Remove(max);
            double sum = 0;
            foreach (var item in tmp)
            {
                sum += Math.Pow(item, 2);
            }
            if (Math.Pow(max, 2) == sum)
            {
                res = "Прямокутний." + Environment.NewLine + Environment.NewLine + $"Сума квадратів катетів дорівнює квадрату гіпотенузи, тобто сторони з довжиною {max}.";
            }
            else if (Math.Pow(max, 2) > sum)
            {
                res = "Тупокутний." + Environment.NewLine + Environment.NewLine + $"Квадрат сторони з довжиною {max} є більшим за суму квадратів інших двох сторін.";
            }
            return res;
        }
        private string Check4Equilateral(List<int> triangleSides)
        {
            string res = "";
            double avg = triangleSides.Average();
            if (avg == triangleSides.First())
            {
                res = "Рівносторонній." + Environment.NewLine + Environment.NewLine + $"Усі сторони трикутника дорівнюють {triangleSides.First()}.";
            }
            return res;
        }
        private string Check4Oxygon(List<int> triangleSides)
        {
            string res = "";
            foreach (var t in triangleSides)
            {
                var tmp = new List<int>(triangleSides);
                tmp.Remove(t);
                var sum = 0d;
                foreach (var tt in tmp)
                {
                    sum += Math.Pow(tt, 2);
                }
                if (Math.Pow(t, 2) < sum)
                {
                    res = "Гострокутний." + Environment.NewLine + Environment.NewLine + $"Квадрат кожної сторони менший за суму квадратів інших двох сторін.";
                }
                else
                {
                    res = "";
                }
            }
            return res;
        }
        private void CalculateTriangle()
        {
            tbOutput.Text = "";
            var triangleSides = new List<int>() { Convert.ToInt32(tbA.Text) , Convert.ToInt32(tbB.Text), Convert.ToInt32(tbC.Text) };
            
            string res = Check4Equilateral(triangleSides); //перевіряємо на рівносторонність
            if (!String.IsNullOrEmpty(res))
            {
                tbOutput.Text = res;
            }
            else
            {
                res = Check4Isosceles(triangleSides); //перевіряємо на рівнобедреність
                if (!String.IsNullOrEmpty(res))
                {
                    tbOutput.Text = res;
                }
                else
                {
                    res = Check4RightOrObtuse(triangleSides);  //перевіряємо на прямокутність або тупокутність
                    if (!String.IsNullOrEmpty(res))
                    {
                        tbOutput.Text = res;
                    }
                    else
                    {
                        res = Check4Oxygon(triangleSides); //перевіряємо на гострокутність
                        if (!String.IsNullOrEmpty(res))
                        {
                            tbOutput.Text = res;
                        }
                    }
                }
            }
        }
    }
}
