using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace WindowsFormsApplication2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private string enterName;
        private string total;
        private void SaveButton1_Click(object sender, EventArgs e)
        {
            enterName = enterNametextbox.Text;
            NamespaceH

            enterNametextbox.Text = string.Empty;

            

        }

        private void ShowAllbutton2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(enterNametextbox.Text);
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            
        }
    }
}
