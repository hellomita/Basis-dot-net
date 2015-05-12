namespace StudentReg
{
    partial class StudentInformation
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
            this.RegtextBox1 = new System.Windows.Forms.TextBox();
            this.firstnametextBox2 = new System.Windows.Forms.TextBox();
            this.lastnametextBox3 = new System.Windows.Forms.TextBox();
            this.ShowButton1 = new System.Windows.Forms.Button();
            this.retrieveButton2 = new System.Windows.Forms.Button();
            this.clearButton3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(44, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Student Information";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(98, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Reg. No";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(88, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "First Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(91, 142);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "last Name";
            // 
            // RegtextBox1
            // 
            this.RegtextBox1.Location = new System.Drawing.Point(168, 50);
            this.RegtextBox1.Name = "RegtextBox1";
            this.RegtextBox1.Size = new System.Drawing.Size(138, 20);
            this.RegtextBox1.TabIndex = 4;
            // 
            // firstnametextBox2
            // 
            this.firstnametextBox2.Location = new System.Drawing.Point(168, 90);
            this.firstnametextBox2.Name = "firstnametextBox2";
            this.firstnametextBox2.Size = new System.Drawing.Size(236, 20);
            this.firstnametextBox2.TabIndex = 5;
            // 
            // lastnametextBox3
            // 
            this.lastnametextBox3.Location = new System.Drawing.Point(168, 135);
            this.lastnametextBox3.Name = "lastnametextBox3";
            this.lastnametextBox3.Size = new System.Drawing.Size(236, 20);
            this.lastnametextBox3.TabIndex = 6;
            // 
            // ShowButton1
            // 
            this.ShowButton1.Location = new System.Drawing.Point(47, 187);
            this.ShowButton1.Name = "ShowButton1";
            this.ShowButton1.Size = new System.Drawing.Size(75, 23);
            this.ShowButton1.TabIndex = 7;
            this.ShowButton1.Text = "save";
            this.ShowButton1.UseVisualStyleBackColor = true;
            this.ShowButton1.Click += new System.EventHandler(this.ShowButton1_Click);
            // 
            // retrieveButton2
            // 
            this.retrieveButton2.Location = new System.Drawing.Point(204, 187);
            this.retrieveButton2.Name = "retrieveButton2";
            this.retrieveButton2.Size = new System.Drawing.Size(75, 23);
            this.retrieveButton2.TabIndex = 8;
            this.retrieveButton2.Text = "Show all";
            this.retrieveButton2.UseVisualStyleBackColor = true;
            this.retrieveButton2.Click += new System.EventHandler(this.retrieveButton2_Click);
            // 
            // clearButton3
            // 
            this.clearButton3.Location = new System.Drawing.Point(407, 187);
            this.clearButton3.Name = "clearButton3";
            this.clearButton3.Size = new System.Drawing.Size(75, 23);
            this.clearButton3.TabIndex = 9;
            this.clearButton3.Text = "Clear All";
            this.clearButton3.UseVisualStyleBackColor = true;
            this.clearButton3.Click += new System.EventHandler(this.clearButton3_Click);
            // 
            // StudentInformation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(531, 261);
            this.Controls.Add(this.clearButton3);
            this.Controls.Add(this.retrieveButton2);
            this.Controls.Add(this.ShowButton1);
            this.Controls.Add(this.lastnametextBox3);
            this.Controls.Add(this.firstnametextBox2);
            this.Controls.Add(this.RegtextBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "StudentInformation";
            this.Text = "Student Information UI";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox RegtextBox1;
        private System.Windows.Forms.TextBox firstnametextBox2;
        private System.Windows.Forms.TextBox lastnametextBox3;
        private System.Windows.Forms.Button ShowButton1;
        private System.Windows.Forms.Button retrieveButton2;
        private System.Windows.Forms.Button clearButton3;
    }
}

