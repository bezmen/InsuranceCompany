﻿using System;
using System.Windows.Forms;

namespace InsuranceCompany
{
    static class MainClass
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FormAllClients());
        }
    }
}
