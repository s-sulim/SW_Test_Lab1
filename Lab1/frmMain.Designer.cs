namespace Lab1
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tbA = new System.Windows.Forms.TextBox();
            this.tbB = new System.Windows.Forms.TextBox();
            this.tbC = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.tbOutput = new System.Windows.Forms.TextBox();
            this.lbdOutput = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tbA
            // 
            this.tbA.Location = new System.Drawing.Point(100, 182);
            this.tbA.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbA.Name = "tbA";
            this.tbA.Size = new System.Drawing.Size(73, 30);
            this.tbA.TabIndex = 1;
            this.tbA.TextChanged += new System.EventHandler(this.tb_TextChanged);
            this.tbA.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_KeyPress);
            // 
            // tbB
            // 
            this.tbB.Location = new System.Drawing.Point(348, 419);
            this.tbB.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbB.Name = "tbB";
            this.tbB.Size = new System.Drawing.Size(73, 30);
            this.tbB.TabIndex = 2;
            this.tbB.TextChanged += new System.EventHandler(this.tb_TextChanged);
            this.tbB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_KeyPress);
            // 
            // tbC
            // 
            this.tbC.Location = new System.Drawing.Point(504, 182);
            this.tbC.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbC.Name = "tbC";
            this.tbC.Size = new System.Drawing.Size(73, 30);
            this.tbC.TabIndex = 3;
            this.tbC.TextChanged += new System.EventHandler(this.tb_TextChanged);
            this.tbC.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_KeyPress);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tbA);
            this.panel1.Controls.Add(this.tbB);
            this.panel1.Controls.Add(this.tbC);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(605, 490);
            this.panel1.TabIndex = 4;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Lab1.Properties.Resources.triangle__1_;
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(26, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(500, 478);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(634, 322);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(125, 40);
            this.btnCalculate.TabIndex = 5;
            this.btnCalculate.Text = "Calcuate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // tbOutput
            // 
            this.tbOutput.Location = new System.Drawing.Point(634, 107);
            this.tbOutput.Multiline = true;
            this.tbOutput.Name = "tbOutput";
            this.tbOutput.ReadOnly = true;
            this.tbOutput.Size = new System.Drawing.Size(203, 184);
            this.tbOutput.TabIndex = 6;
            // 
            // lbdOutput
            // 
            this.lbdOutput.AutoSize = true;
            this.lbdOutput.Location = new System.Drawing.Point(640, 72);
            this.lbdOutput.Name = "lbdOutput";
            this.lbdOutput.Size = new System.Drawing.Size(74, 23);
            this.lbdOutput.TabIndex = 7;
            this.lbdOutput.Text = "Output: ";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(900, 535);
            this.Controls.Add(this.lbdOutput);
            this.Controls.Add(this.tbOutput);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Triangle type calc";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox tbA;
        private System.Windows.Forms.TextBox tbB;
        private System.Windows.Forms.TextBox tbC;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.TextBox tbOutput;
        private System.Windows.Forms.Label lbdOutput;
    }
}

