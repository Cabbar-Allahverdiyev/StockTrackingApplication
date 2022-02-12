using Business.ValidationRules;
using Entities.Concrete;
using FluentValidation.Results;
using System;
using System.Collections.Generic;
using System.Text;
using WindowsForm.Core.Constants.Messages;

namespace WindowsForm.Core.Controllers.Concrete.ValidatorControllers
{
    public class CustomerPaymentValidationTool
    {
        public bool IsValid(CustomerPayment entity)
        {
            CustomerPaymentValidator validationRules = new CustomerPaymentValidator();
            ValidationResult results = validationRules.Validate(entity);

            if (results.IsValid == false)
            {
                foreach (ValidationFailure failure in results.Errors)
                {
                    FormsMessage.WarningMessage(failure.ErrorMessage);

                }
                return false;

            }
            return true;
        }
    }
}
