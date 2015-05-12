using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace @new
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private List<string> emails = new List<string>();



        private void button1_Click(object sender, EventArgs e)
        {
            string email = savetextbox1.Text;

            if (email.Contains("@") && email.Contains("."))
            {

            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
