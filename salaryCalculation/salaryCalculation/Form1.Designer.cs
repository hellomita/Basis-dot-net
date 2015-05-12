namespace salaryCalculation
{
    partial class Form1
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
            this.addbutton1 = new System.Windows.Forms.Button();
            this.substractbutton2 = new System.Windows.Forms.Button();
            this.multiplybutton3 = new System.Windows.Forms.Button();
            this.dividebutton4 = new System.Windows.Forms.Button();
            this.firsttextBox1 = new System.Windows.Forms.TextBox();
            this.secondtextBox2 = new System.Windows.Forms.TextBox();
            this.resulttextbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // addbutton1
            // 
            this.addbutton1.Location = new System.Drawing.Point(31, 280);
            this.addbutton1.Name = "addbutton1";
            this.addbutton1.Size = new System.Drawing.Size(75, 23);
            this.addbutton1.TabIndex = 0;
            this.addbutton1.Text = "Add";
            this.addbutton1.UseVisualStyleBackColor = true;
            this.addbutton1.Click += new System.EventHandler(this.addbutton1_Click);
            // 
            // substractbutton2
            // 
            this.substractbutton2.Location = new System.Drawing.Point(145, 280);
            this.substractbutton2.Name = "substractbutton2";
            this.substractbutton2.Size = new System.Drawing.Size(75, 23);
            this.substractbutton2.TabIndex = 1;
            this.substractbutton2.Text = "Substract";
            this.substractbutton2.UseVisualStyleBackColor = true;
            this.substractbutton2.Click += new System.EventHandler(this.substractbutton2_Click);
            // 
            // multiplybutton3
            // 
            this.multiplybutton3.Location = new System.Drawing.Point(253, 280);
            this.multiplybutton3.Name = "multiplybutton3";
            this.multiplybutton3.Size = new System.Drawing.Size(75, 23);
            this.multiplybutton3.TabIndex = 2;
            this.multiplybutton3.Text = "Multiply";
            this.multiplybutton3.UseVisualStyleBackColor = true;
            this.multiplybutton3.Click += new System.EventHandler(this.multiplybutton3_Click);
            // 
            // dividebutton4
            // 
            this.dividebutton4.Location = new System.Drawing.Point(368, 280);
            this.dividebutton4.Name = "dividebutton4";
            this.dividebutton4.Size = new System.Drawing.Size(75, 23);
            this.dividebutton4.TabIndex = 3;
            this.dividebutton4.Text = "Divide";
            this.dividebutton4.UseVisualStyleBackColor = true;
            this.dividebutton4.Click += new System.EventHandler(this.dividebutton4_Click);
            // 
            // firsttextBox1
            // 
            this.firsttextBox1.Location = new System.Drawing.Point(194, 43);
            this.firsttextBox1.Name = "firsttextBox1";
            this.firsttextBox1.Size = new System.Drawing.Size(165, 20);
            this.firsttextBox1.TabIndex = 4;
            // 
            // secondtextBox2
            // 
            this.secondtextBox2.Location = new System.Drawing.Point(194, 115);
            this.secondtextBox2.Name = "secondtextBox2";
            this.secondtextBox2.Size = new System.Drawing.Size(165, 20);
            this.secondtextBox2.TabIndex = 5;
            // 
            // resulttextbox
            // 
            this.resulttextbox.Location = new System.Drawing.Point(194, 179);
            this.resulttextbox.Name = "resulttextbox";
            this.resulttextbox.Size = new System.Drawing.Size(165, 20);
            this.resulttextbox.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(100, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "First Number";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(82, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Second Number";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(95, 186);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Result";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(504, 341);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.resulttextbox);
            this.Controls.Add(this.secondtextBox2);
            this.Controls.Add(this.firsttextBox1);
            this.Controls.Add(this.dividebutton4);
            this.Controls.Add(this.multiplybutton3);
            this.Controls.Add(this.substractbutton2);
            this.Controls.Add(this.addbutton1);
            this.Name = "Form1";
            this.Text = "Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button addbutton1;
        private System.Windows.Forms.Button substractbutton2;
        private System.Windows.Forms.Button multiplybutton3;
        private System.Windows.Forms.Button dividebutton4;
        private System.Windows.Forms.TextBox firsttextBox1;
        private System.Windows.Forms.TextBox secondtextBox2;
        private System.Windows.Forms.TextBox resulttextbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

