using Business.Constants.Messages;
using Entities.Concrete;
using FluentValidation.Results;
using System;
using System.Collections.Generic;
using System.Text;
using WindowsForm.Core.Constants.Messages;

namespace WindowsForm.Core.Controllers.Concrete.ValidatorControllers
{
    public class BonusCardValidationTool
    {
        public bool IsValid(BonusCard entity)
        {
           BonusCardValidator validationRules = new BonusCardValidator();
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
