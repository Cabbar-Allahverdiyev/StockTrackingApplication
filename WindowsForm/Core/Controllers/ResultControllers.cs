using Business.Constants.Messages;
using Core.Utilities.Results;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using WindowsForm.Core.Constants.Messages;

namespace WindowsForm.Core.Controllers
{
    public static class ResultControllers
    {
        public static void ResultIsSucces(IResult result)
        {
            if (!result.Success)
            {
                FormsMessage.ErrorMessage(result.Message);
                return;
            }

        }
    }
}
