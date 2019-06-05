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
    public partial class FormAddNewEmployee : Form
    {
        List<Employee> employees;
        public FormAddNewEmployee(List<Employee> employees)
        {
            this.employees = employees;
            InitializeComponent();
            
        }

        private void Add_Click(object sender, EventArgs e)
        {
            employees.Add(new Employee(textBoxFIO.Text, textBoxAddress.Text, textBoxTelephone.Text));
            this.Close();
        }
    }
}
