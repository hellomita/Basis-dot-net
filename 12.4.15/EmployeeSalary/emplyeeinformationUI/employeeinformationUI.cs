using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace emplyeeinformationUI
{
    public partial class employeeinformationUI : Form
    {

        Employee employeeObj = new Employee();


        public employeeinformationUI()
        {
            InitializeComponent();
        }

        private void showbutton_Click(object sender, EventArgs e)
        {
            employeeObj.id = idTextBox.Text;
            employeeObj.name = nameTextBox.Text;
            employeeObj.salary = Convert.ToDouble(salaryTextBox.Text);
            ClearEmplyeeinformation();
            MessageBox.Show("emplyeeinformation." + "\nid: "
                + employeeObj.id + "\nName: " + employeeObj.name +
                "\nSalary: " + employeeObj.salary);

        }

        private void ClearEmplyeeinformation()
        {
            idTextBox.Text = "";
            nameTextBox.Text = "";
            salaryTextBox.Text = "";

        }

        private void retrievebutton_Click(object sender, EventArgs e)
        {
            idTextBox.Text = employeeObj.id;
            nameTextBox.Text = employeeObj.name;
            salaryTextBox.Text = employeeObj.salary.ToString();

        }

        private void salaryTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
