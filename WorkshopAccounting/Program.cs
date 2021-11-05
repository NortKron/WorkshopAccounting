using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

using WorkshopAccounting.Presenter;
using WorkshopAccounting.View;

namespace WorkshopAccounting
{
    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            MainForm mainForm = new();
            MainPresenter presenter = new(mainForm);

            Application.Run(mainForm);
            //Application.Run(new MainForm());
        }
    }
}
