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

        public FormPolicy(List<Client> clients, List<Employee> employees, FormAllClients main)
        {
            InitializeComponent();
            this.clients = clients;
            this.employees = employees;
            this.main = main;
            foreach (var item in employees)
                comboBoxEmployee.Items.Add(item);
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
        }
    }
}
