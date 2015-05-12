using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bookInfo
{
    public partial class Form1 : Form
    {
        private Hashtable hashtable = new Hashtable();
        public Form1()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            hashtable.Add(isbntextBox1.Text,textBox4.Text);
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void isbnButton_click2_Click(object sender, EventArgs e)
        {
            if (hashtable.Contains(isbntextBox1.Text))
            {
                textBox1.Text = hashtable[isbntextBox1.Text].ToString();
            }
            else
            {
                MessageBox.Show("Not Found");
            }
        }
    }
}
