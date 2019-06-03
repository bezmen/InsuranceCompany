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
    public partial class FormAllClients : Form
    {
        Dictionary<Category, List<Subcategory>> dicCategory = new Dictionary<Category, List<Subcategory>>();
        List<Client> clients = new List<Client>();
        List<Employee> employees = new List<Employee>();

        public FormAllClients()
        {
            InitializeComponent();

            listView1.Columns.Add("ФИО", -2, HorizontalAlignment.Left);
            listView1.Columns.Add("Тип", -2, HorizontalAlignment.Center);
            listView1.Columns.Add("Адрес", -2, HorizontalAlignment.Center);
            listView1.Columns.Add("Суммарные выплаты", -2, HorizontalAlignment.Left);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormInformClient startForm = new FormInformClient(clients);
            startForm.ShowDialog();
            ListViewItem item1 = new ListViewItem("item1", 0);
            listView1.FullRowSelect = true;
            item1.SubItems.Add("Name");
            item1.SubItems.Add("Type");
            item1.SubItems.Add("Address");
            listView1.Items.Add(item1);
        }

        private void buttonAddNewCategory_Click(object sender, EventArgs e)
        {
            FormAddNewCategory startForm = new FormAddNewCategory();
            startForm.ShowDialog();
        }

        private void buttonAddNewEmployee_Click(object sender, EventArgs e)
        {
            FormAddNewEmployee startForm = new FormAddNewEmployee(employees);
            startForm.ShowDialog();
        }
    }
}
