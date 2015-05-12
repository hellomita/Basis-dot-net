using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace personael_information
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private string firstName;
        private string lastName;
        private string fatherName;
        private string motherName;
        private string address;
        private void button1_Click(object sender, EventArgs e)
        {
            firstName = firstNameTextBox.Text;
            lastName = lastNameTextBox.Text ;
            fatherName = fatherNameTextBox.Text;
            motherName = motherNameTextBox .Text ;
            address = addressTextBox.Text;
            firstNameTextBox.Text = string.Empty;
            lastNameTextBox.Text = string.Empty;
            fatherNameTextBox.Text = string.Empty;
            motherNameTextBox.Text = string.Empty;
            addressTextBox.Text = string.Empty;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show()
        }
    }
}
