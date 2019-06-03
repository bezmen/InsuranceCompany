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
        public FormPolicy(List<Client> clients)
        {
            InitializeComponent();
            this.clients = clients;
        }

        private void buttonConclude_Click(object sender, EventArgs e)
        {

        }
    }
}
