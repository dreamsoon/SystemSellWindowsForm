using Automation_1.Admin_forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Automation_1.Modula;
using Automation_1.User_forms;
using System.Threading;

namespace Automation_1
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
            Application.ThreadException += Application_ThreadException;        
            Application.Run(new frm_LogIn());
            if (PublicVariebale.gSetUser == 1)
            {
                frm_MainAdmin frm = new frm_MainAdmin();
                frm.ShowDialog();
            }
          else  {
                
                lbl_newsandinformation fm = new lbl_newsandinformation();
                fm.ShowDialog();
            }

           
            }

        private static void Application_ThreadException(object sender, ThreadExceptionEventArgs e)
        {
            ErrorHandler.GetError(e.Exception);
        }
    }
    
}

