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
    public partial class FormAddNewCategory : Form
    {
        Dictionary<Category, List<Subcategory>> dicCategory;

        public FormAddNewCategory(Dictionary<Category, List<Subcategory>> dicCategory)
        {
            this.dicCategory = dicCategory;
            InitializeComponent();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            dicCategory.Add(new Category(textBoxCategory.Text), new List<Subcategory>());
            this.Close();
        }
    }
}
