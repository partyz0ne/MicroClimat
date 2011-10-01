using System;
using System.Windows.Forms;
using MicroClimat.Forms;
using MicroClimat.Classes;
using MicroClimat.Properties;

namespace MicroClimat
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            CLogger.Open();
            if (args.Length == 0 || args[0] == String.Empty)
                Application.Run(new MainForm(Settings.Default.LastProject));
            else
                Application.Run(new MainForm(args[0]));
            CLogger.AddInfo("Остановка приложения.");
        }
    }
}
