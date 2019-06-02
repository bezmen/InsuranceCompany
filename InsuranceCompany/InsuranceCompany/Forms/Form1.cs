using InsuranceCompany.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InsuranceCompany
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            // Create columns for the items and subitems.
            // Width of -2 indicates auto-size.
            listView1.Columns.Add("ФИО", -2, HorizontalAlignment.Left);
            listView1.Columns.Add("Тип", -2, HorizontalAlignment.Center);
            listView1.Columns.Add("Адрес", -2, HorizontalAlignment.Center);
            listView1.Columns.Add("Суммарные выплаты", -2, HorizontalAlignment.Left);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form3 startForm = new Form3();
            startForm.ShowDialog();
            ListViewItem item1 = new ListViewItem("item1", 0);
            listView1.FullRowSelect = true;
            item1.SubItems.Add("Name");
            item1.SubItems.Add("Type");
            item1.SubItems.Add("Address");
            listView1.Items.Add(item1);
        }
    }
}
