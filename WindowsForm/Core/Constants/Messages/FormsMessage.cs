using Business.Constants.Messages;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using WindowsForm.Forms;

namespace WindowsForm.Core.Constants.Messages
{
    public static class FormsMessage
    {
        public static void Alert(string message, AlertForm.EnumType type)
        {
            AlertForm form = new AlertForm();
            form.ShowAlert(message, type);
        }

        public static void InformationMessage(string resultMessage)
        {
            Alert(resultMessage, AlertForm.EnumType.Info);
        }
        public static void ErrorMessage(string resultMessage)
        {
            Alert(resultMessage, AlertForm.EnumType.Error);
            //MessageBox.Show(resultMessage, AuthMessages.ErrorMessage, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }



    }
}
