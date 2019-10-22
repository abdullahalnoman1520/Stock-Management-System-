using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StockManagementWinApp
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
           Application.Run(new LoginForm());
             //Application.Run(new StockOutForm());
             //Application.Run(new StockInForm());
             //Application.Run(new ItemForm());
             //Application.Run(new StockReportForm());

        }
    }
}
