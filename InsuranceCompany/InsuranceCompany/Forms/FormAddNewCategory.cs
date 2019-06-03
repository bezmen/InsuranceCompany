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
        int x = 100;
        int y = 17;
        public FormAddNewCategory()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            y +=30;
            TextBox text = new TextBox();
            text.Location = new System.Drawing.Point(x, y);
            text.Name = "textBox1";
            text.Size = new System.Drawing.Size(100, 20);
            this.Controls.Add(text);
        }
    }
}
