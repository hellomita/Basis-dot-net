using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace interestCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double result;
            double principalAmount = Convert.ToInt32(pc_amounttextbox.text);
            double interestRate = Convert.ToInt32(yr_Growtextbox.text);
            int compoundInterest = Convert.ToInt32(yr_Growtextbox.text);
            int year = Convert.ToInt32(yr_Growtextbox.text);
            double finalResult;



            
            double value = 1 + (interestRate/compoundInterest);
            double rate = compoundInterest*year;
             result= Math.Pow(value,rate);
            finalResult = principalAmount*result;
            futureText.Text = finalResult.ToString();

        }
    }
}
