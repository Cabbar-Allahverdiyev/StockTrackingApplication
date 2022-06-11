using Business.Abstract;
using System;
using System.Collections.Generic;
using System.Text;
using WindowsForm.Core.Constants.Messages;
using WindowsForm.Forms;

namespace WindowsForm.Utilities.Helpers.Selectors.CustomerSelectors
{
    public class SelectForCustomerSelectForm
    {
        public static bool CustomerSelect(ref int customerId,ICustomerService _customerService)
        {
            customerId = 0;
            CustomerSelectForm customerSelectForm = new CustomerSelectForm(_customerService);
            customerSelectForm.ShowDialog();
            if (CustomerSelectForm.CustomerId == 0)
            {
                FormsMessage.WarningMessage(FormsTextMessages.IdBlank);
                return false;
            }
            customerId = CustomerSelectForm.CustomerId;
            return true;
        }
    }
}
