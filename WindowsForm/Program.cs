using Business.Concrete;
using Core.Utilities.Security.JWT;
using DataAccess.Concrete.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsForm
{
    static class Program
    {

        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        /// 



        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            // Application.Run(new Forms.Dashboard());
            //Application.Run(new Forms.UserForms.UserDashboard());

            Application.Run(new Forms.LoginForm());

            //Application.Run(new Forms.SalesForm());
            //Application.Run(new Forms.UserForms.AdminValidationForm());
           //Application.Run(new Forms.CustomerPaymentForm()) ;
           //Application.Run(new Forms.CustomerForm()) ;

        }
    }
}
