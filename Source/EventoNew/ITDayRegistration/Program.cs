﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace ITDayRegistration
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
            DevExpress.UserSkins.BonusSkins.Register();

            Application.Run(new MainForm());
        }
    }
}
