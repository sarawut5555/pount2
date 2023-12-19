using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pount2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ListViewItem Newitem = new ListViewItem(textBox1.Text);
            Newitem.SubItems.Add(textBox2.Text);
            Newitem.SubItems.Add(textBox3.Text);
            Newitem.SubItems.Add(textBox4.Text);
            listView1.Items.Add(Newitem);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listView1.Items.Remove(listView1.SelectedItems[0]);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            listView1.Clear();
            textBox1.Text = string.Empty;
            textBox2.Text = string.Empty;
            textBox3.Text = string.Empty;
            textBox4.Text = string.Empty;
        }
    }
}
