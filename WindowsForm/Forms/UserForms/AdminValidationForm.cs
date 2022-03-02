using Business.Constants.Messages;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using WindowsForm.Core.Constants.FormsAuthorization.User;
using WindowsForm.Core.Constants.Messages;

namespace WindowsForm.Forms.UserForms
{
    public partial class AdminValidationForm : Form
    {
        public AdminValidationForm()
        {
            InitializeComponent();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            string value = textBox1.Text;
            UserAuthorization.QrCodeIsSuccess = false;
            if (value.Length==13)
            {
               
                if (value.Equals("0000000361236"))
                {
                    //SalesFormForUser.QrCodeIsSuccess = true;
                   // FormSalesListForUser.QrCodeIsSuccess = true;
                    UserAuthorization.QrCodeIsSuccess = true;
                    FormsMessage.SuccessMessage(AuthMessages.Alowed);
                    this.Hide();
                }
            }
        }
    }
}
