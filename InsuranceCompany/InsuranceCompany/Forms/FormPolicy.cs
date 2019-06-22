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
        FormAllClients main;
        Client client;

        public FormPolicy(Client client, FormAllClients main)
        { 
            this.main = main;
            this.client = client;

            InitializeComponent();

            textBoxClient.Enabled = false;
            textBoxNumPolicy.Text = main.countPolycies.ToString();//

            comboBoxTerm.Items.Add("1 месяц");
            comboBoxTerm.Items.Add("3 месяца");
            comboBoxTerm.Items.Add("6 месяцев");
            comboBoxTerm.Items.Add("1 год");

            comboBoxPaymentTerm.Items.Add("3 дня");
            comboBoxPaymentTerm.Items.Add("7 дней");
            comboBoxPaymentTerm.Items.Add("1 месяц");
            comboBoxPaymentTerm.Items.Add("3 месяца");

            foreach (var item in main.dicCategory)
                comboBoxCategory.Items.Add(item.Key);

            foreach (var item in main.employees)
                comboBoxEmployee.Items.Add(item);

            textBoxClient.Text = client.Name;
        }

        private void buttonConclude_Click(object sender, EventArgs e)
        {
            if (client is IndividualClient)
            {
                client.Policies.Add(new IncurencePolicy(
                    main.countPolycies,
                    comboBoxEmployee.SelectedItem as Employee,
                    comboBoxCategory.SelectedItem as Category,
                    dateTimePickerConclude.Value,
                    getTermOfImprisonment(),
                    Convert.ToDecimal(textBoxSumPolicy.Text),
                    Convert.ToDecimal(textBoxCostPolicy.Text),
                    getPaymentTerm()
                    ));
                main.countPolycies++;
            }
            else if (client is EntityClient)
            {
                client.Policies.Add(new IncurencePolicy(
                    main.countPolycies,
                    comboBoxEmployee.SelectedItem as Employee,
                    comboBoxCategory.SelectedItem as Category,
                    dateTimePickerConclude.Value,
                    getTermOfImprisonment(),
                    Convert.ToDecimal(textBoxSumPolicy.Text),
                    Convert.ToDecimal(textBoxCostPolicy.Text),
                    getPaymentTerm()
                    ));
                main.countPolycies++;
            }
            this.Close();
        }
        private DateTime getTermOfImprisonment()
        {
            DateTime date = DateTime.Now;
            switch (comboBoxTerm.SelectedIndex)
            {
                case 0: date = date.AddMonths(1);
                    break;
                case 1: date = date.AddMonths(3);
                    break;
                case 2: date = date.AddMonths(6);
                    break;
                default: date = date.AddYears(1);
                    break;
            }
            return date;
        }

        private int getPaymentTerm()
        {
            int days = 0;
            switch (comboBoxPaymentTerm.SelectedIndex)
            {
                case 0: days = 3;
                    break;
                case 1: days = 7;
                    break;
                case 2: days = 30;
                    break;
                case 3: days = 90;
                    break;
                default:
                    break;
            }
            return days;
        }
    }
}
