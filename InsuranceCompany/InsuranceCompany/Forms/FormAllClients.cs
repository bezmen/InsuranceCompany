using InsuranceCompany.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InsuranceCompany
{
    public partial class FormAllClients : Form
    {
        public Dictionary<Category, List<Subcategory>> dicCategory = new Dictionary<Category, List<Subcategory>>();
        public List<Client> clients = new List<Client>();
        public List<Employee> employees = new List<Employee>();
        public int countPolycies = 1;

        public FormAllClients()
        {
            //TODO: здесь десиреализовать объект и приравнять все списки его спискам
            BinaryFormatter formatter = new BinaryFormatter();
            if (File.Exists("save.dat"))
            {
                using (FileStream data = new FileStream("save.dat", FileMode.OpenOrCreate))
                {
                    Session newSession = (Session)formatter.Deserialize(data);
                    dicCategory = newSession.dicCategory;
                    clients = newSession.clients;
                    employees = newSession.employees;
                    countPolycies = newSession.countPolycies;
                }
            }
            InitializeComponent();
            dicCategory.Add(new Category("КАСКО"), new List<Subcategory>() { new Subcategory("item1", 2), new Subcategory("item2", 3) });
            employees.Add(new Employee("Безмен А. Л.", "ул. Чапаева 41-2", "+375333539190"));
            listView1.Columns.Add("Клиент", -10, HorizontalAlignment.Left);
            listView1.Columns.Add("Тип", -10, HorizontalAlignment.Center);
            listView1.Columns.Add("УНП", -10, HorizontalAlignment.Center);
            listView1.Columns.Add("Адрес", -10, HorizontalAlignment.Center);
            listView1.Columns.Add("Суммарные выплаты", -2, HorizontalAlignment.Left);
            foreach (Client client in clients)
            {
                ListViewItem item = new ListViewItem(client.Name.ToString(), 0);
                item.SubItems.Add((client is IndividualClient) ? "физ.лицо" : "юр.лицо");
                item.SubItems.Add(client.UTN.ToString());
                item.SubItems.Add(client.Address.ToString());
                item.SubItems.Add(client.SumPayouts.ToString());
                listView1.Items.Add(item);
            }

            listView1.FullRowSelect = true;
        }

        private void buttonGetIncurency_Click(object sender, EventArgs e)
        {
            FormAllClients main = this;
            FormCustomerProfile startForm = new FormCustomerProfile(main);
            startForm.ShowDialog();

            var client = clients.Last();

            ListViewItem item = new ListViewItem(client.Name.ToString(), 0);
            item.SubItems.Add("физ. лицо");
            item.SubItems.Add(client.UTN);
            item.SubItems.Add(client.Address);
            item.SubItems.Add(client.SumPayouts.ToString());
            main.listView1.Items.Add(item);
        }

        private void buttonAddNewCategory_Click(object sender, EventArgs e)
        {
            FormAllClients main = this;
            FormAddNewCategory startForm = new FormAddNewCategory(main);
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
            FormProcessingOfPayout startForm = new FormProcessingOfPayout(main);
            startForm.ShowDialog();
        }

        private void listView1_DoubleClick(object sender, EventArgs e)
        {
            FormAllClients main = this;
            string selectedClient = listView1.SelectedItems[0].SubItems[2].Text;
            FormClient startForm = new FormClient(findSelectedClient(selectedClient), main);
            startForm.ShowDialog();
        }
        private void buttonListCategories_Click(object sender, EventArgs e)
        {
            FormAllClients main = this;
            FormShowAllCategories startForm = new FormShowAllCategories(main);
            startForm.Show();
        }

        private Client findSelectedClient(string UTN) => clients.Find(k => k.UTN.Equals(UTN));

        private void FormAllClients_FormClosing(object sender, FormClosingEventArgs e)
        {
            //TODO: сериалисовать объект Session и приравнять все списки в его конструктор
            string nowDate = DateTime.Now.ToShortDateString();
            Session session = new Session(employees, clients, dicCategory, countPolycies);
            BinaryFormatter formatter = new BinaryFormatter();
            using (FileStream data = new FileStream(string.Format("save.dat", nowDate), FileMode.OpenOrCreate))
            {
                formatter.Serialize(data, session);
            }
        }
    }
}
