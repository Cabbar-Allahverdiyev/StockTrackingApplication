using Business.ValidationRules.FluentValidation;
using Entities.Concrete;
using FluentValidation.Results;
using System;
using System.Collections.Generic;
using System.Text;
using WindowsForm.Core.Constants.Messages;

namespace WindowsForm.Core.Controllers.Concrete.ValidatorControllers
{
    public class CustomerValidationTool
    {
        public bool IsValid(Customer customer)
        {
            CustomerValidator validationRules = new CustomerValidator();
            ValidationResult results = validationRules.Validate(customer);

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
