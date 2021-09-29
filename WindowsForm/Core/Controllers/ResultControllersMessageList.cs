using Core.Utilities.Results;
using System;
using System.Collections.Generic;
using System.Text;

namespace WindowsForm.Core.Controllers
{
    public class ResultControllersMessageList
    {
        public string ResultIsSuccesMessage(IResult result)
        {
            if (!result.Success)
            {
                return result.Message;
            }
            return result.Message;
        }
    }
}
