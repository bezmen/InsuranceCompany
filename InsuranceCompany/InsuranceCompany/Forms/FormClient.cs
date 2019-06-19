using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/*      public int Number { get; set; }
        public Employee Employee { get; set; }
        public Category Category { get; set; }
        public DateTime DateOfConclusion { get; set; }
        public DateTime TermOfImprisonment { get; set; }
        public decimal Sum { get; set; }
        public decimal Cost { get; set; }
        public int PaymentTerm { get; set; }*/

namespace InsuranceCompany.Forms
{
    public partial class FormClient : Form
    {
        Client client;
        public FormClient(Client client)
        {
            this.client = client;
            InitializeComponent();
            listView1.Columns.Add("№", -10, HorizontalAlignment.Left);
            listView1.Columns.Add("Категория", -10, HorizontalAlignment.Center);
            listView1.Columns.Add("Дата соглашения", -10, HorizontalAlignment.Center);
            listView1.Columns.Add("Дата окончания", -2, HorizontalAlignment.Left);
            listView1.Columns.Add("Сумма", -2, HorizontalAlignment.Left);
            listView1.Columns.Add("Стоимость", -2, HorizontalAlignment.Left);
            listView1.Columns.Add("Срок выплаты(дн.)", -2, HorizontalAlignment.Left);
            listView1.FullRowSelect = true;

            //ListViewItem item;
            //foreach (var policy in client.Policies)
            //{
            //    item = new ListViewItem(policy.Number.ToString(), 0);
            //    item.SubItems.Add(policy.Category.Name);
            //    item.SubItems.Add(policy.DateOfConclusion.ToShortDateString());
            //    item.SubItems.Add(policy.TermOfImprisonment.ToShortDateString());
            //    item.SubItems.Add(policy.Sum.ToString());
            //    item.SubItems.Add(policy.Sum.ToString());
            //    item.SubItems.Add(policy.PaymentTerm.ToString() + " дн");
            //    listView1.Items.Add(item);
            //}

            //ListViewItem item = new ListViewItem();
            //item.SubItems.Add("физ. лицо");
            //item.SubItems.Add(client.Address);
            //item.SubItems.Add(client.SumPayouts.ToString());
            //main.listView1.Items.Add(item);

            listView1.FullRowSelect = true;
        }
    }
}
