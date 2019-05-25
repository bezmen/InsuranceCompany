using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InsuranceCompany
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());

            Employee oleg = new Employee();
            Category category = new Category();
            Individual sasha = new Individual();

            IncurencePolicy incurencePolicy = new IncurencePolicy(0, oleg, category, sasha, new DateTime(), new DateTime(), 15, 1500, 6);
        }
    }
}
