using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace planetApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string planetName = planetNameComboBox.Text;

            Dictionary comboSource = new Dictionary();
            comboSource.Add("1", "Sunday");
            comboSource.Add("2", "Monday");
            comboSource.Add("3", "Tuesday");
            comboSource.Add("4", "Wednesday");
            comboSource.Add("5", "Thursday");
            comboSource.Add("6", "Friday");
            comboSource.Add("7", "Saturday");
            planetNameComboBox.DataSource = new BindingSource(comboSource, null);
            planetNameComboBox.DisplayMember = "Value";
            planetNameComboBox.ValueMember = "Key";


            if (planetName == "Planet")
            {
                MessageBox.Show("It is in 3rd position");
            }
            else if (planetName == "Saturn")
            {
                MessageBox.Show("It is in 6th position");
            }
            else if (planetName == "Mars")
            {
                MessageBox.Show("It is in 4th position");
            }
            else
            {
                MessageBox.Show("I dont know");

            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string key = ((KeyValuePair)planetNameComboBox.SelectedItem).Key;
            string value = ((KeyValuePair)planetNameComboBox.SelectedItem).Value;
            MessageBox.Show(key + "   " + value);
        }
    }
}
