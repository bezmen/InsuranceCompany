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
    public partial class FormShowAllCategories : Form
    {
        FormAllClients main;

        public FormShowAllCategories(FormAllClients main)
        {
            this.main = main;
            InitializeComponent();

            foreach (var category in main.dicCategory.Keys)
            {
                listBox1.Items.Add(category.Name);
                for (int i = 0; i < main.dicCategory[category].Count; i++)
                {
                    listBox1.Items.Add("\t--" + main.dicCategory[category][i].Name);
                }
            }
        }
    }
}
