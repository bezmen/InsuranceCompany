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
    public partial class FormRegistrationAppeal : Form
    {
        Dictionary<Category, List<Subcategory>> dicCategory;
        List<Client> clients;
        List<Appeal> appeals;

        public FormRegistrationAppeal(List<Client> clients, Dictionary<Category, List<Subcategory>> dicCategory, List<Appeal> appeals)
        {
            this.dicCategory = dicCategory;
            this.clients = clients;
            this.appeals = appeals;
            InitializeComponent();

            foreach (var item in clients)
                comboBoxClient.Items.Add(item);
        }

        private void buttonRegistration_Click(object sender, EventArgs e)
        {
            appeals.Add(new Appeal(
                comboBoxClient.SelectedItem as Client,
                comboBoxCategory.SelectedItem as Category,
                comboBoxSubcategory.SelectedItem as Subcategory));
            this.Close();
        }

        private void comboBoxClient_SelectedValueChanged(object sender, EventArgs e)
        {
            comboBoxCategory.SelectedItem = null;
            comboBoxCategory.Items.Clear();
            foreach (var item in (comboBoxClient.SelectedItem as Client).Policies)
                comboBoxCategory.Items.Add(item.Category);
        }

        private void comboBoxСategory_SelectedValueChanged(object sender, EventArgs e)
        {
            comboBoxSubcategory.SelectedItem = null;
            comboBoxSubcategory.Items.Clear();
            for (int i = 0; i < dicCategory[(Category)comboBoxCategory.SelectedItem].Count; i++)
            {
                comboBoxSubcategory.Items.Add(dicCategory[comboBoxCategory.SelectedItem as Category][i]);
            }
        }
    }
}
