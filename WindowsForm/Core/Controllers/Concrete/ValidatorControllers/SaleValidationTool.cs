using Business.ValidationRules.FluentValidation;
using Entities.Concrete;
using FluentValidation.Results;
using System;
using System.Collections.Generic;
using System.Text;
using WindowsForm.Core.Constants.Messages;

namespace WindowsForm.Core.Controllers.ValidatorControllers
{
    public class SaleValidationTool
    {
        public bool IsValid(Sale sale)
        {
            SaleValidator validationRules = new SaleValidator();
            ValidationResult results = validationRules.Validate(sale);

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
