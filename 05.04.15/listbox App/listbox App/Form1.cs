using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace listbox_App
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
           showlistBoxText.Items.Clear();
            for (int i = 0; i < 9; i++)
            {
                showlistBoxText.Items.Add(i.ToString());

            }
        }

        private void showlistBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
