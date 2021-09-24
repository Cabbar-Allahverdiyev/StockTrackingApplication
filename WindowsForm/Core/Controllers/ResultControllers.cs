using Business.Constants.Messages;
using Core.Utilities.Results;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace WindowsForm.Core.Controllers
{
    public  class ResultControllers
    {
        public  void ResultIsSucces(IResult result)
        {
            if (!result.Success)
            {
                MessageBox.Show(result.Message, AuthMessages.ErrorMessage, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            MessageBox.Show(result.Message, AuthMessages.InformationMessage, MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
    }
}
