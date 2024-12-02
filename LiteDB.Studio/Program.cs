using System;
using System.Windows.Forms;
using ICSharpCode.TextEditor.Util;

namespace LiteDB.Studio
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            Application.ApplicationExit += OnExit;
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm(args));
        }

        private static void OnExit(object sender, EventArgs eventArgs)
        {
            Application.ApplicationExit -= OnExit;
            AppSettingsManager.PersistData();
        }
    }
}