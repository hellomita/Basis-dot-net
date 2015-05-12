using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace salaryCalculation
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Calculator calculation = new Calculator();
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        public void GetValue()
        {
            calculation.first = Convert.ToInt32(firsttextBox1.Text);
            calculation.second = Convert.ToInt32(secondtextBox2.Text);
            
        }

        private void addbutton1_Click(object sender, EventArgs e)
        {
            //calculation.first = Convert.ToInt32(firsttextBox1.Text);
            //calculation.second = Convert.ToInt32(secondtextBox2.Text);
            GetValue();
            resulttextbox.Text = calculation.AddCalculation().ToString();




        }

        private void substractbutton2_Click(object sender, EventArgs e)
        {
            //calculation.first = Convert.ToInt32(firsttextBox1.Text);
            //calculation.second = Convert.ToInt32(secondtextBox2.Text);
            GetValue();
            resulttextbox.Text = calculation.SubstractCalculation().ToString();
        }

        private void multiplybutton3_Click(object sender, EventArgs e)
        {
            //calculation.first = Convert.ToInt32(firsttextBox1.Text);
            //calculation.second = Convert.ToInt32(secondtextBox2.Text);
            GetValue();
            resulttextbox.Text = calculation.MultiCalculation().ToString();
        }

        private void dividebutton4_Click(object sender, EventArgs e)
        {
            //calculation.first = Convert.ToInt32(firsttextBox1.Text);
            //calculation.second = Convert.ToInt32(secondtextBox2.Text);
            GetValue();
            resulttextbox.Text = calculation.DivideCalculation().ToString();
        }
    }
}
