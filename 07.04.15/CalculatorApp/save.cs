using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculatorApp
{
    public partial class save : Form
    {
        public save()
        {
            InitializeComponent();
        }
        string path = @"E:\MITA\07.04.15\CalculatorApp\Mita\inmfo.txt";
        private void savebutton_Click(object sender, EventArgs e)
        {
            string path = @"E:\MITA\07.04.15\CalculatorApp\Mita\inmfo.txt";
            FileStream aFilestream = new FileStream(path, FileMode.Append);
            StreamWriter aStreamWriter = new StreamWriter(aFilestream);
            aStreamWriter.WriteLine(nameTextBox.Text );
            aStreamWriter.Close();
            aFilestream  .Close();
            nameTextBox.Text = string.Empty;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            outputListBox.Items.Clear();

            FileStream aFilestream = new FileStream(path, FileMode.Open);
            StreamReader arReader = new StreamReader(aFilestream);

            while (!arReader.EndOfStream)
            {
                string name = arReader.ReadLine();
                outputListBox.Items.Add(name);

            }
            arReader.Close();
            aFilestream.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string path = @"E:\MITA\07.04.15\CalculatorApp\Mita\inmfo.txt";
            FileStream aFilestream = new FileStream(path, FileMode.Create);
            StreamWriter aStreamWriter = new StreamWriter(aFilestream);
            aStreamWriter.WriteLine(nameTextBox.Text);
            aStreamWriter.Close();
            aFilestream.Close();
            nameTextBox.Text = string.Empty;
        }
    }
}
