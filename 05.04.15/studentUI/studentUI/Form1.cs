using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace studentUI
{
    public partial class Form1 : Form
    {
        //public string regNo;
        //public string firstName;
        //public string lastName;
        public Form1()
        {
            InitializeComponent();
        }

        private void showbutton_Click(object sender, EventArgs e)
        {

            student aStudent = new student(); 
            aStudent regNo = regNoTextBox.Text;
            aStudent firstName = firstNameTextBox.Text;
            aStudent lastName = lastNameTextBox.Text;
            regNoTextBox.Text=String.Empty  ;
            firstNameTextBox.Text=string .Empty ;
            lastNameTextBox.Text=string .Empty ;

            MessageBox.Show("heloo" + firstName + " "+lastName +" "+"your"+regNo );

        }

        private void retrievebutton_Click(object sender, EventArgs e)
        {
          regNoTextBox.Text=regNo ;
          firstNameTextBox.Text=firstName ;
          lastNameTextBox.Text=lastName ;

        }

        private void Clearbutton_Click(object sender, EventArgs e)
        {
            regNo = null;
            firstName = null;
            lastName = null;
            regNoTextBox.Clear();
            firstNameTextBox.Clear();
            lastNameTextBox.Clear();

        }
    }
}
