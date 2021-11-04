using Business.Constants.Messages;
using Core.Utilities.Results;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using WindowsForm.Core.Constants.Messages;
using WindowsForm.Forms;

namespace WindowsForm.Core.Controllers
{
    public static class ResultControllers
    {
        public static void ResultIsSucces(IResult result)
        {
            if (!result.Success)
            {
                Alert(result.Message, AlertForm.EnumType.Error);
               // FormsMessage.ErrorMessage(result.Message);
                return;
            }

        }

        public static void Alert(string message,AlertForm.EnumType type)
        {
            AlertForm form = new AlertForm();
            form.ShowAlert(message, type);
        }
    }
}
