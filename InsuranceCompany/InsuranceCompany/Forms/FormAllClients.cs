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
            dicCategory.Add(new Category("КАСКО"), new List<Subcategory>() { new Subcategory("item1"), new Subcategory("item2") });
            employees.Add(new Employee("Безмен А. Л.", "ул. Чапаева 41-2", "+375333539190"));
            listView1.Columns.Add("Клиент", -10, HorizontalAlignment.Left);
            listView1.Columns.Add("Тип", -10, HorizontalAlignment.Center);
            listView1.Columns.Add("Адрес", -10, HorizontalAlignment.Center);
            listView1.Columns.Add("Суммарные выплаты", -2, HorizontalAlignment.Left);
            listView1.FullRowSelect = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormAllClients main = this;
            FormInformClient startForm = new FormInformClient(clients, employees, main, dicCategory);
            startForm.ShowDialog();
        }

        private void buttonAddNewCategory_Click(object sender, EventArgs e)
        {
            FormAddNewCategory startForm = new FormAddNewCategory(dicCategory);
            startForm.ShowDialog();
        }

        private void buttonAddNewEmployee_Click(object sender, EventArgs e)
        {
            FormAddNewEmployee startForm = new FormAddNewEmployee(employees);
            startForm.ShowDialog();
        }

        private void buttonAddNewSubcategory_Click(object sender, EventArgs e)
        {
            FormAddNewSubcategoty startForm = new FormAddNewSubcategoty(dicCategory);
            startForm.ShowDialog();
        }

        private void buttonRegistrationAppeal_Click(object sender, EventArgs e)
        {
            FormRegistrationAppeal startForm = new FormRegistrationAppeal();
            startForm.ShowDialog();
        }

        private void buttonRegistrationOfPayment_Click(object sender, EventArgs e)
        {
            FormRegistrationOfPayment startForm = new FormRegistrationOfPayment();
            startForm.ShowDialog();
        }
    }
}
