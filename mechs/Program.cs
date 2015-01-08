// ------------------------------------------------------------------------
// <copyright file="Program.cs" company="Databrain">
//     Databrain. All rights reserved
// </copyright>
// <author>
//     Dmitry Piskun
// </author>
// <summary>
//      Initially created on 25/11/2013
// </summary>
// ------------------------------------------------------------------------

using Common.Logging;

namespace Mechs
{
    using System;
    using System.Windows.Forms;
    using Mechs.Common.Interfaces;

    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            AppDomain.CurrentDomain.UnhandledException += CurrentDomain_UnhandledException;

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            var log = LogManager.GetCurrentClassLogger();
            log.Info("Info log");
            log.Debug("Debug log");
            log.Warn("Warn log");
 
            Application.Run(new MainForm());
        }

        static void CurrentDomain_UnhandledException(object sender, UnhandledExceptionEventArgs e)
        {
            var log = LogManager.GetCurrentClassLogger();
            log.FatalFormat("Unhandled exception: {0}", e.ExceptionObject);
        }
    }
}