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
        List<Payout> payouts;

        public FormProcessingOfPayout(List<Client> clients, List<Payout> payouts)
        {
            this.clients = clients;
            this.payouts = payouts;

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
                    comboBoxAppeal.Items.Add(item.Appeals[i]);
        }

        private void comboBoxAppeal_SelectedValueChanged(object sender, EventArgs e)
        {
            textBoxCategory.Text = (comboBoxAppeal.SelectedItem as Appeal).Category.Name;
            textBoxSubcategory.Text = (comboBoxAppeal.SelectedItem as Appeal).Subcategory.Name;
        }
    }
}
