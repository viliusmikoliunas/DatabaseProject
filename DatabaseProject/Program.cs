﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DatabaseProject
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

            StartupForm startup = new StartupForm();
            DriverForm driverForm = new DriverForm();
            startup.FormBorderStyle = FormBorderStyle.FixedDialog;
            Application.Run(driverForm);
        }
    }
}