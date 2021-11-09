using Business.ValidationRules.FluentValidation;
using Entities.Concrete;
using FluentValidation.Results;
using System;
using System.Collections.Generic;
using System.Text;
using WindowsForm.Core.Constants.Messages;

namespace WindowsForm.Core.Controllers.ValidatorControllers
{
    public class SupplierValidationTool
    {
        public bool IsValid(Supplier supplier)
        {
            SupplierValidator validationRules = new SupplierValidator();
            ValidationResult results = validationRules.Validate(supplier);

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
