using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Word = Microsoft.Office.Interop.Word;

namespace InsuranceCompany.Forms
{
    public partial class FormClient : Form
    {
        Client client;
        FormAllClients main;

        public FormClient(Client client, FormAllClients main)
        {
            this.main = main;
            this.client = client;
            InitializeComponent();
            listView1.FullRowSelect = true;
        }

        private void buttonShowPolicies_Click(object sender, EventArgs e)
        {
            listView1.Clear();
            ListViewItem item;
            listView1.Columns.Add("№", -2, HorizontalAlignment.Left);
            listView1.Columns.Add("Категория", -2, HorizontalAlignment.Center);
            listView1.Columns.Add("Дата соглашения", -2, HorizontalAlignment.Center);
            listView1.Columns.Add("Дата окончания", -2, HorizontalAlignment.Left);
            listView1.Columns.Add("Сумма", -2, HorizontalAlignment.Left);
            listView1.Columns.Add("Стоимость", -2, HorizontalAlignment.Left);
            listView1.Columns.Add("Срок выплаты(дн.)", -2, HorizontalAlignment.Left);
            foreach (var policy in client.Policies)
            {
                
                item = new ListViewItem(policy.Number.ToString(), 0);
                item.SubItems.Add(policy.Category.Name);
                item.SubItems.Add(policy.DateOfConclusion.ToShortDateString());
                item.SubItems.Add(policy.TermOfImprisonment.ToShortDateString());
                item.SubItems.Add(policy.Sum.ToString());
                item.SubItems.Add(policy.Cost.ToString());
                item.SubItems.Add(policy.PaymentTerm.ToString() + " дн");
                listView1.Items.Add(item);
            }
        }

        private void buttonShowPayouts_Click(object sender, EventArgs e)
        {
            listView1.Clear();
            ListViewItem item;
            listView1.Columns.Add("Категория", 2, HorizontalAlignment.Left);
            listView1.Columns.Add("Страховой случай", -2, HorizontalAlignment.Left);
            listView1.Columns.Add("Дата обращения", -2, HorizontalAlignment.Left);
            listView1.Columns.Add("Дата выплаты", -2, HorizontalAlignment.Left);
            listView1.Columns.Add("Сумма выплаты", -2, HorizontalAlignment.Left);

            foreach (var payout in client.Payouts)
            {
                item = new ListViewItem(payout.Category.Name, 0);
                item.SubItems.Add(payout.Subcategory.Name);
                item.SubItems.Add(payout.DateOfAppeal.ToShortDateString());
                item.SubItems.Add(payout.DateOfPayout.ToShortDateString());
                item.SubItems.Add(payout.SumPayout.ToString());
                listView1.Items.Add(item);
            }
        }

        private void buttonGetInsurence_Click(object sender, EventArgs e)
        {
            FormPolicy startForm = new FormPolicy(client, main);
            ListViewItem item;
            startForm.ShowDialog();
            var policy = client.Policies.Last();

            item = new ListViewItem(policy.Number.ToString(), 0);
            item.SubItems.Add(policy.Category.Name);
            item.SubItems.Add(policy.DateOfConclusion.ToShortDateString());
            item.SubItems.Add(policy.TermOfImprisonment.ToShortDateString());
            item.SubItems.Add(policy.Sum.ToString());
            item.SubItems.Add(policy.Cost.ToString());
            item.SubItems.Add(policy.PaymentTerm.ToString() + " дн");
            listView1.Items.Add(item);
        }


        private IncurencePolicy findSelectedPolicy(string number) => client.Policies.Find(k => k.Number.ToString().Equals(number));

        private void buttonExport_Click(object sender, EventArgs e)
        {
            var wordApp = new Word.Application();
            wordApp.Visible = false;

            var wordDocument = wordApp.Documents.Open("lol.docx");
        }
    }
}
