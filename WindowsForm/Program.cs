using Business.Concrete;
using Business.Constants.Messages;
using Core.Utilities.Security.JWT;
using DataAccess.Concrete.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsForm.Core.Constants.Messages;

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

            //Application.Run(new Forms.LoginForm());



            //Application.Run(new Forms.StatisticForProductForm());
            //Application.Run(new Forms.AdminForms.AdminVerificationForm(new UserManager(new EfUserDal())));
            Application.Run(new Forms.AdminForms.OperationClaimForm(new UserManager(new EfUserDal())
                            ,new OperationClaimForFormsManager(new EfOperationClaimForFormsDal())
                            ,new UserOperationClaimForFormsManager(new EfUserOperationClaimForFormsDal())
                            ));
            //Application.Run(new Forms.CustomerPaymentForm()) ;


        }
    }
}
