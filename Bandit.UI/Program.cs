using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bandit.UI
{
    internal static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            try
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.ThreadException += Application_ThreadException;
                AppDomain.CurrentDomain.UnhandledException += CurrentDomain_UnhandledException;
                Application.Run(new Form1());
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Критическая ошибка при запуске приложения:\n{ex.Message}", 
                    "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private static void Application_ThreadException(object sender, System.Threading.ThreadExceptionEventArgs e)
        {
            MessageBox.Show($"Необработанная ошибка потока:\n{e.Exception.Message}\n\nПриложение продолжит работу.", 
                "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private static void CurrentDomain_UnhandledException(object sender, UnhandledExceptionEventArgs e)
        {
            Exception ex = e.ExceptionObject as Exception;
            MessageBox.Show($"Критическая необработанная ошибка:\n{ex?.Message ?? "Неизвестная ошибка"}", 
                "Критическая ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
