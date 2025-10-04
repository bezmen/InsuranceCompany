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
    public partial class FormAddNewSubcategoty : Form
    {
        Dictionary<Category, List<Subcategory>> dicCategory;
        public FormAddNewSubcategoty(Dictionary<Category, List<Subcategory>> dicCategory)
        {
            this.dicCategory = dicCategory;
            InitializeComponent();
            foreach (var item in dicCategory)
            {
                comboBoxCategory.Items.Add(item.Key);
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            dicCategory[(Category)comboBoxCategory.SelectedItem].Add(new Subcategory(textBoxInsuranceCase.Text, Convert.ToDouble(textBoxPercent.Text)));
            this.Close();
        }
    }
}
