using AbuEhab.LowyersSystem.Interface.Forms.Employees_Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace AbuEhab.LowyersSystem.Interface
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FrmEmployees());
        }
    }
}
