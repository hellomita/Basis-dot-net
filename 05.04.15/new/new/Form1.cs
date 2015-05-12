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

        private void button1_Click(object sender, EventArgs e)
        {
            public partial class Form1 : Form {
    // Content item for the combo box
    private class Item {
        public string Name;
        public int Value;
        public Item(string name, int value) {
            Name = name; Value = value;
        }
        public override string ToString() {
            // Generates the text shown in the combo box
            return Name;
        }
    }
    public Form1() {
        InitializeComponent();
        // Put some stuff in the combo box
        comboBox1.Items.Add(new Item("Blue", 1));
        comboBox1.Items.Add(new Item("Red", 2));
        comboBox1.Items.Add(new Item("Nobugz", 666));
    }

    private void comboBox1_SelectedIndexChanged(object sender, EventArgs e) {
        // Display the Value property
        Item itm = (Item)comboBox1.SelectedItem;
        Console.WriteLine("{0}, {1}", itm.Name, itm.Value);
    }
}
        }
    }
}
