using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListView
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ListViewItem lv1 = new ListViewItem("Mélanie");
            lv1.SubItems.Add("Laroche");
            lv1.SubItems.Add("444 Saint-Joseph");
            listView1.Items.Add(lv1);

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
