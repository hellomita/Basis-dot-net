namespace compoundInterestCalculator
{
    partial class InterestCalculator
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.pcAmount_textbox = new System.Windows.Forms.TextBox();
            this.ir_textbox = new System.Windows.Forms.TextBox();
            this.ci_textbox = new System.Windows.Forms.TextBox();
            this.yrGrow_textbox = new System.Windows.Forms.TextBox();
            this.fta_textbox = new System.Windows.Forms.TextBox();
            this.calculatebutton1 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(68, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Principal Amount";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(86, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Interest Rate";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(58, 137);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Compound Interest";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(80, 174);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Years to Grow";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(51, 221);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Future Total Amount";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(329, 134);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "time(s) annually";
            // 
            // pcAmount_textbox
            // 
            this.pcAmount_textbox.Location = new System.Drawing.Point(177, 41);
            this.pcAmount_textbox.Name = "pcAmount_textbox";
            this.pcAmount_textbox.Size = new System.Drawing.Size(257, 20);
            this.pcAmount_textbox.TabIndex = 6;
            // 
            // ir_textbox
            // 
            this.ir_textbox.Location = new System.Drawing.Point(177, 87);
            this.ir_textbox.Name = "ir_textbox";
            this.ir_textbox.Size = new System.Drawing.Size(100, 20);
            this.ir_textbox.TabIndex = 7;
            this.ir_textbox.TextChanged += new System.EventHandler(this.ir_textbox_TextChanged);
            // 
            // ci_textbox
            // 
            this.ci_textbox.Location = new System.Drawing.Point(177, 134);
            this.ci_textbox.Name = "ci_textbox";
            this.ci_textbox.Size = new System.Drawing.Size(133, 20);
            this.ci_textbox.TabIndex = 8;
            // 
            // yrGrow_textbox
            // 
            this.yrGrow_textbox.Location = new System.Drawing.Point(177, 171);
            this.yrGrow_textbox.Name = "yrGrow_textbox";
            this.yrGrow_textbox.Size = new System.Drawing.Size(133, 20);
            this.yrGrow_textbox.TabIndex = 9;
            // 
            // fta_textbox
            // 
            this.fta_textbox.Location = new System.Drawing.Point(177, 221);
            this.fta_textbox.Name = "fta_textbox";
            this.fta_textbox.Size = new System.Drawing.Size(133, 20);
            this.fta_textbox.TabIndex = 10;
            // 
            // calculatebutton1
            // 
            this.calculatebutton1.Location = new System.Drawing.Point(332, 169);
            this.calculatebutton1.Name = "calculatebutton1";
            this.calculatebutton1.Size = new System.Drawing.Size(117, 23);
            this.calculatebutton1.TabIndex = 11;
            this.calculatebutton1.Text = "Calculate";
            this.calculatebutton1.UseVisualStyleBackColor = true;
            this.calculatebutton1.Click += new System.EventHandler(this.calculatebutton1_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(283, 90);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(15, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "%";
            // 
            // InterestCalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(574, 349);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.calculatebutton1);
            this.Controls.Add(this.fta_textbox);
            this.Controls.Add(this.yrGrow_textbox);
            this.Controls.Add(this.ci_textbox);
            this.Controls.Add(this.ir_textbox);
            this.Controls.Add(this.pcAmount_textbox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "InterestCalculator";
            this.Text = "Interest Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox pcAmount_textbox;
        private System.Windows.Forms.TextBox ir_textbox;
        private System.Windows.Forms.TextBox ci_textbox;
        private System.Windows.Forms.TextBox yrGrow_textbox;
        private System.Windows.Forms.TextBox fta_textbox;
        private System.Windows.Forms.Button calculatebutton1;
        private System.Windows.Forms.Label label7;
    }
}

