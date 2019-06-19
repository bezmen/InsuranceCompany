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
    public partial class FormProcessingOfPayout : Form
    {
        List<Client> clients;
        FormAllClients main;

        public FormProcessingOfPayout(List<Client> clients, FormAllClients main)
        {
            this.clients = clients;
            this.main = main;
 
            InitializeComponent();

            foreach (var item in clients)
                comboBoxClient.Items.Add(item);
        }

        private void comboBoxClient_SelectedValueChanged(object sender, EventArgs e)
        {
            comboBoxAppeal.SelectedItem = null;
            comboBoxAppeal.Items.Clear();

            foreach (var item in clients)
                for (int i = 0; i < item.Appeals.Count; i++)
                    if (item.Appeals[i].IsOppened == true)
                        comboBoxAppeal.Items.Add(item.Appeals[i]);
        }

        private void comboBoxAppeal_SelectedValueChanged(object sender, EventArgs e)
        {
            textBoxCategory.Text = null;
            textBoxSubcategory.Text = null;
            textBoxCategory.Text = (comboBoxAppeal.SelectedItem as Appeal).Category.Name;
            textBoxSubcategory.Text = (comboBoxAppeal.SelectedItem as Appeal).Subcategory.Name;
        }

        private void buttonAccept_Click(object sender, EventArgs e)
        {
            (comboBoxClient.SelectedItem as Client).Payouts.Add(new Payout(
                (comboBoxAppeal.SelectedItem as Appeal).Category,
                (comboBoxAppeal.SelectedItem as Appeal).Subcategory,
                (comboBoxAppeal.SelectedItem as Appeal).DateOfAppeal,
                DateTime.Now,
                Convert.ToDecimal(textBoxSumPayout.Text)
                ));
            (comboBoxClient.SelectedItem as Client).SumPayouts += Convert.ToDecimal(textBoxSumPayout.Text);

            var idIdx = main.listView1.Columns[2].Index;
            var codeIdx = main.listView1.Columns[4].Index;

            foreach (ListViewItem item in main.listView1.Items)
            {
                if (item.SubItems[idIdx].Text == (comboBoxClient.SelectedItem is IndividualClient? (comboBoxClient.SelectedItem as IndividualClient).UTN: (comboBoxClient.SelectedItem as EntityClient).UTN))
                {
                    item.SubItems[codeIdx].Text = (comboBoxClient.SelectedItem as Client).SumPayouts.ToString();
                    break;
                }
            }
            main.listView1.Refresh();

            (comboBoxAppeal.SelectedItem as Appeal).State = Appeal.StateAppeal.Accepted;
            (comboBoxAppeal.SelectedItem as Appeal).IsOppened = false;

            this.Close();
        }

        private void buttonDenied_Click(object sender, EventArgs e)
        {
            (comboBoxAppeal.SelectedItem as Appeal).State = Appeal.StateAppeal.Denied;
            (comboBoxAppeal.SelectedItem as Appeal).IsOppened = false;
            this.Close();
        }
    }
}
