using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Calculator : Form
    {
        public Calculator()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            result.Text = ((Convert.ToInt32(first.Text)+ Convert.ToInt32(Second.Text)).ToString());
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            result.Text = ((Convert.ToInt32(first.Text)- Convert.ToInt32(Second.Text)).ToString());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            result.Text = ((Convert.ToInt32(first.Text)* Convert.ToInt32(Second.Text)).ToString());
        }

        private void button4_Click(object sender, EventArgs e)
        {
            result.Text = ((Convert.ToInt32(first.Text)/ Convert.ToInt32(Second.Text)).ToString());
        }
    }
}
