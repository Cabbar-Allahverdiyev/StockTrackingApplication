using Business.Constants.Messages;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace WindowsForm.Core.Constants.Messages
{
    public static class FormsMessage
    {
        public static void InformationMessage(string resultMessage)
        {
            MessageBox.Show(resultMessage, AuthMessages.InformationMessage, MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
        public static void ErrorMessage(string resultMessage)
        {
            MessageBox.Show(resultMessage, AuthMessages.ErrorMessage, MessageBoxButtons.OK, MessageBoxIcon.Error);

        }
    }
}
