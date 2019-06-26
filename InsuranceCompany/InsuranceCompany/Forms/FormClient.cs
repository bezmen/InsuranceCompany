using System;
using System.Linq;
using System.Windows.Forms;
using Microsoft.Office.Interop.Word;

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
                item = new ListViewItem(payout.Policy.Category.Name, 0);
                item.SubItems.Add(payout.Subcategory.Name);
                item.SubItems.Add(payout.DateOfAppeal.ToShortDateString());
                item.SubItems.Add(payout.DateOfPayout.ToShortDateString());
                item.SubItems.Add(payout._Payout.ToString());
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
            Microsoft.Office.Interop.Word.Application app = new Microsoft.Office.Interop.Word.Application();
            Document doc = app.Documents.Add(Visible: true);
            Range range = doc.Range();
            Table table = doc.Tables.Add(range, 9, 6);
            table.Borders.Enable = 1;

            table.Cell(1, 1).Range.Text = "Клиент:";
            table.Cell(2, 1).Range.Text = "УНП:";
            table.Cell(3, 1).Range.Text = "Адрес:";
            table.Cell(4, 1).Range.Text = "Телефон:";
            table.Cell(5, 1).Range.Text = "Тип:";
            table.Cell(6, 1).Range.Text = "Руководитель";
            table.Cell(7, 1).Range.Text = "Главбух:";

            table.Cell(8, 1).Range.Text = "Дата полиса";
            table.Cell(8, 2).Range.Text = "Категория полиса";
            table.Cell(8, 3).Range.Text = "Действует до";
            table.Cell(8, 4).Range.Text = "Cумма полиса, руб";
            table.Cell(8, 5).Range.Text = "Стоимость полиса, руб";
            table.Cell(8, 6).Range.Text = "Cуммарные выплаты, руб";

            table.Cell(1, 2).Range.Text = client.Name;
            table.Cell(2, 2).Range.Text = client.UTN;
            table.Cell(3, 2).Range.Text = client.Address;
            table.Cell(4, 2).Range.Text = client.Telephone;
            table.Cell(5, 2).Range.Text = (client is IndividualClient) ? "Физическое лицо" : "Юридическое лицо";
            table.Cell(6, 2).Range.Text = (client is IndividualClient) ? "" : (client as EntityClient).FIO_Director;
            table.Cell(7, 2).Range.Text = (client is IndividualClient) ? "" : (client as EntityClient).FIO_ChiefAccountant;
            int i = 8;
            foreach (var policy in client.Policies)
            {
                foreach (Row row in table.Rows)
                {
                    if (row.Index > i)
                    {
                        table.Rows.Add();
                        foreach (Cell cell in row.Cells)
                        {
                            switch (cell.ColumnIndex)
                            {
                                case 1:
                                    cell.Range.Text = policy.DateOfConclusion.ToShortDateString();
                                    break;
                                case 2:
                                    cell.Range.Text = policy.Category.Name;
                                    break;
                                case 3:
                                    cell.Range.Text = policy.TermOfImprisonment.ToShortDateString();
                                    break;
                                case 4:
                                    cell.Range.Text = policy.Sum.ToString();
                                    break;
                                case 5:
                                    cell.Range.Text = policy.Cost.ToString();
                                    break;
                                case 6:
                                    cell.Range.Text = policy.SumPayouts.ToString();
                                    break;
                                default:
                                    break;
                            }
                        }
                        i++;
                        break;
                    }
                }
            }

            int lastRow = table.Rows.Count;
            decimal sumSumPolicies = 0;
            decimal sumCostPolicies = 0;
            decimal sumPayouts = client.SumPayouts;
            foreach (var policy in client.Policies)
            {
                sumSumPolicies += policy.Sum;
                table.Rows.Add();
                table.Cell(lastRow, 1).Range.Text = "ИТОГО";
                table.Cell(lastRow, 4).Range.Text = sumSumPolicies.ToString();
                table.Cell(lastRow, 5).Range.Text = sumCostPolicies.ToString();
                table.Cell(lastRow, 6).Range.Text = sumPayouts.ToString();

                for (int j = 1; j <= 7; j++)
                {
                    doc.Range(table.Rows[j].Cells[2].Range.Start, table.Rows[j].Cells[6].Range.End).Cells.Merge();
                }

                doc.Range(table.Rows[lastRow].Cells[1].Range.Start, table.Rows[lastRow].Cells[3].Range.End).Cells.Merge();
                doc.Save();
                app.Quit();
            }
        }
    }
}
