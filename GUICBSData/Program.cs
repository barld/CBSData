using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUICBSData
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
            //Application.SetCompatibleTextRenderingDefault(false);
            /*if (Globals.MainWindow == null)
                Globals.MainWindow = new MainWindow();*/
            Application.Run(Globals.MainWindow);
        }
    }
}
