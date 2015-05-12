using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentReg
{
    public partial class StudentInformation : Form
    {
        public StudentInformation()
        {
            InitializeComponent();
        }

        List<string> StudentInformationclass  students  = new StudentInformationclass();
        
        public void ShowButton1_Click(object sender, EventArgs e)
        {
            aStudent.regNo = RegtextBox1.Text;
            aStudent.firstName = firstnametextBox2.Text;
            aStudent.lastName = lastnametextBox3.Text;

            //ClearButtonClick();
            MessageBox.Show(aStudent.GetFullName());
            
            RegtextBox1.Text = String.Empty;
            firstnametextBox2.Text = String.Empty;
            lastnametextBox3.Text = String.Empty;


            
               
            
            


        }

        

        private void retrieveButton2_Click(object sender, EventArgs e)
        {
            string studentInfo = "";

            foreach ( VARIABLE in COLLECTION)
            {
               studentInfo += aStudent.regNo;
              aStudent.firstName;
               aStudent.lastName;
            }

             
        }

        private void clearButton3_Click(object sender, EventArgs e)
        {
            RegtextBox1.Text = "";
            firstnametextBox2.Text = "";
            lastnametextBox3.Text = "";
        }
    }
}
