namespace PersonalInfoApp
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.firstNametextbox = new System.Windows.Forms.TextBox();
            this.lastNametextbox = new System.Windows.Forms.TextBox();
            this.motherNametextbox = new System.Windows.Forms.TextBox();
            this.fatherNametextbox = new System.Windows.Forms.TextBox();
            this.addresstextbox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.Savebutton1 = new System.Windows.Forms.Button();
            this.ShowAllinfobutton2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(42, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Personal Infomation";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "First Name:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(43, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Last Name:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 138);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Mother\'s Name:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(26, 116);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Father\'s Name:";
            // 
            // firstNametextbox
            // 
            this.firstNametextbox.Location = new System.Drawing.Point(132, 58);
            this.firstNametextbox.Name = "firstNametextbox";
            this.firstNametextbox.Size = new System.Drawing.Size(161, 20);
            this.firstNametextbox.TabIndex = 1;
            // 
            // lastNametextbox
            // 
            this.lastNametextbox.Location = new System.Drawing.Point(132, 84);
            this.lastNametextbox.Name = "lastNametextbox";
            this.lastNametextbox.Size = new System.Drawing.Size(161, 20);
            this.lastNametextbox.TabIndex = 2;
            this.lastNametextbox.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // motherNametextbox
            // 
            this.motherNametextbox.Location = new System.Drawing.Point(132, 138);
            this.motherNametextbox.Name = "motherNametextbox";
            this.motherNametextbox.Size = new System.Drawing.Size(161, 20);
            this.motherNametextbox.TabIndex = 4;
            this.motherNametextbox.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // fatherNametextbox
            // 
            this.fatherNametextbox.Location = new System.Drawing.Point(132, 113);
            this.fatherNametextbox.Name = "fatherNametextbox";
            this.fatherNametextbox.Size = new System.Drawing.Size(161, 20);
            this.fatherNametextbox.TabIndex = 3;
            // 
            // addresstextbox
            // 
            this.addresstextbox.Location = new System.Drawing.Point(132, 164);
            this.addresstextbox.Multiline = true;
            this.addresstextbox.Name = "addresstextbox";
            this.addresstextbox.Size = new System.Drawing.Size(162, 47);
            this.addresstextbox.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(56, 164);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Address:";
            // 
            // Savebutton1
            // 
            this.Savebutton1.Location = new System.Drawing.Point(46, 229);
            this.Savebutton1.Name = "Savebutton1";
            this.Savebutton1.Size = new System.Drawing.Size(75, 23);
            this.Savebutton1.TabIndex = 6;
            this.Savebutton1.Text = "Save";
            this.Savebutton1.UseVisualStyleBackColor = true;
            this.Savebutton1.Click += new System.EventHandler(this.Savebutton1_Click);
            // 
            // ShowAllinfobutton2
            // 
            this.ShowAllinfobutton2.Location = new System.Drawing.Point(133, 229);
            this.ShowAllinfobutton2.Name = "ShowAllinfobutton2";
            this.ShowAllinfobutton2.Size = new System.Drawing.Size(130, 23);
            this.ShowAllinfobutton2.TabIndex = 7;
            this.ShowAllinfobutton2.Text = "Show All Information";
            this.ShowAllinfobutton2.UseVisualStyleBackColor = true;
            this.ShowAllinfobutton2.Click += new System.EventHandler(this.ShowAllinfobutton2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(234, 258);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 10;
            this.button3.Text = "Address";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(107, 258);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(121, 23);
            this.button4.TabIndex = 9;
            this.button4.Text = "Parent\'s Name";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(29, 258);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 8;
            this.button5.Text = "Name";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(378, 317);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.ShowAllinfobutton2);
            this.Controls.Add(this.Savebutton1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.addresstextbox);
            this.Controls.Add(this.fatherNametextbox);
            this.Controls.Add(this.motherNametextbox);
            this.Controls.Add(this.lastNametextbox);
            this.Controls.Add(this.firstNametextbox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox firstNametextbox;
        private System.Windows.Forms.TextBox lastNametextbox;
        private System.Windows.Forms.TextBox motherNametextbox;
        private System.Windows.Forms.TextBox fatherNametextbox;
        private System.Windows.Forms.TextBox addresstextbox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button Savebutton1;
        private System.Windows.Forms.Button ShowAllinfobutton2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
    }
}

