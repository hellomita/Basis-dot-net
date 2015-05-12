using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PersonalInfoApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private string firstName;
        private string lastName;
        private string fatherName;
        private string motherName;
        private string address;
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Parent's Name:" + fatherName + "" + motherName + "");
        }

        private void Savebutton1_Click(object sender, EventArgs e)
        {
            firstName = firstNametextbox.Text;
            lastName = lastNametextbox.Text;
            fatherName = fatherNametextbox.Text;
            motherName = motherNametextbox.Text;
            address = addresstextbox.Text;

            firstNametextbox.Text = string.Empty;
            lastNametextbox.Text = string.Empty;
            fatherNametextbox.Text = string.Empty;
            motherNametextbox.Text = string.Empty;
            addresstextbox.Text = string.Empty;



        }

        private void ShowAllinfobutton2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Name:" + firstName + "" + lastName + "\nFather's Name:" + fatherName + "\nMother's Name:" +
                            motherName + "\nAddress:" + address +"");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Name:" + firstName + "" + lastName + "");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Address:"+address+"");
        }
    }
}
