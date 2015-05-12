using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace compoundInterestCalculator
{
    public partial class InterestCalculator : Form
    {
        private void interestCalculator()
        {
            InitializeComponent();
        }

        private double principalAmount;
        private double interestRate;
        private double timesPerYear;
        private double years, principal;
        private int compoundInterest;
        private double result;




        private double calculatebutton1_Click(object sender, EventArgs e)
        {
            double principalAmount = Convert.ToInt32(pcAmount_textbox.Text);
            double interestRate = Convert.ToInt32(ir_textbox.Text);
            int compoundInterest = Convert.ToInt32(ci_textbox.Text);
            double years = Convert.ToInt32(yrGrow_textbox.Text);


            double principalAmount = 









        }

        private void ir_textbox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}


