using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InsuranceCompany.Forms
{
    public partial class FormPolicy : Form
    {
        List<Client> clients;
        List<Employee> employees;
        FormAllClients main;
        Dictionary<Category, List<Subcategory>> dicCategory;

        public FormPolicy(List<Client> clients, List<Employee> employees, FormAllClients main, Dictionary<Category, List<Subcategory>> dicCategory)
        {
            InitializeComponent();

            this.clients = clients;
            this.employees = employees;
            this.main = main;
            this.dicCategory = dicCategory;

            textBoxClient.Enabled = false;
;
            comboBoxTerm.Items.Add("1 месяц");
            comboBoxTerm.Items.Add("3 месяца");
            comboBoxTerm.Items.Add("6 месяцев");
            comboBoxTerm.Items.Add("1 год");

            comboBoxPaymentTerm.Items.Add("3 дня");
            comboBoxPaymentTerm.Items.Add("1 неделя");
            comboBoxPaymentTerm.Items.Add("1 месяц");

            foreach (var item in dicCategory)
                comboBoxCategory.Items.Add(item.Key);

            foreach (var item in employees)
                comboBoxEmployee.Items.Add(item);

            if (clients.Last() is IndividualClient)
            {
                var client = clients.Last() as IndividualClient;
                textBoxClient.Text = client.Name;
            }
            else if (clients.Last() is EntityClient)
            {
                var client = clients.Last() as EntityClient;
                textBoxClient.Text = client.NameCompany;
            }

            comboBoxPaymentTerm.Items.Add("3 дня");
            comboBoxPaymentTerm.Items.Add("7 дней");
            comboBoxPaymentTerm.Items.Add("1 месяц");
            comboBoxPaymentTerm.Items.Add("3 месяца");

            // textBoxClient.Text = clients.Last();
            // textBoxNumPolicy.Text =datebase ID;
        }

        private void buttonConclude_Click(object sender, EventArgs e)
        {
            if (clients.Last() is IndividualClient)
            {
                var client = clients.Last() as IndividualClient;
                ListViewItem item = new ListViewItem(client.Name.ToString(), 0);
                item.SubItems.Add("физ. лицо");
                item.SubItems.Add(client.Address);
                main.listView1.Items.Add(item);
            }
            else if (clients.Last() is EntityClient)
            {
                var client = clients.Last() as EntityClient;
                ListViewItem item = new ListViewItem(client.NameCompany.ToString(), 0);
                item.SubItems.Add("юр. лицо");
                item.SubItems.Add(client.Address);
                main.listView1.Items.Add(item);
            }
            this.Close();
        }
    }
}
