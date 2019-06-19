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
            dicCategory.Add(new Category("КАСКО"), new List<Subcategory>() { new Subcategory("item1", 2), new Subcategory("item2", 3) });
            employees.Add(new Employee("Безмен А. Л.", "ул. Чапаева 41-2", "+375333539190"));
            listView1.Columns.Add("Клиент", -10, HorizontalAlignment.Left);
            listView1.Columns.Add("Тип", -10, HorizontalAlignment.Center);
            listView1.Columns.Add("УНП", -10, HorizontalAlignment.Center);
            listView1.Columns.Add("Адрес", -10, HorizontalAlignment.Center);
            listView1.Columns.Add("Суммарные выплаты", -2, HorizontalAlignment.Left);
            listView1.FullRowSelect = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormAllClients main = this;
            FormCustomerProfile startForm = new FormCustomerProfile(clients, employees, main, dicCategory);
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
            FormRegistrationAppeal startForm = new FormRegistrationAppeal(clients, dicCategory);
            startForm.ShowDialog();
        }

        private void buttonRegistrationOfPayment_Click(object sender, EventArgs e)
        {
            FormAllClients main = this;
            FormProcessingOfPayout startForm = new FormProcessingOfPayout(clients, main);
            startForm.ShowDialog();
        }

        private void listView1_DoubleClick(object sender, EventArgs e)
        {
            //var item = (listView1.SelectedItems[0] as Client).UTN;
            string selectedClient = listView1.SelectedItems[0].SubItems[2].Text;//.ToString();
            FormClient startForm = new FormClient(findSelectedClient(selectedClient));
            startForm.ShowDialog();
        }


        private Client findSelectedClient(string UTN)
        {
            return clients.Find(k => k.UTN.Equals(UTN));
        }
    }
}
