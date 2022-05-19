using Core.CrossCuttingConcerns.Validation;
using FluentValidation;
using FluentValidation.Results;
using System;
using System.Collections.Generic;
using System.Text;
using WindowsForm.Core.Constants.Messages;

namespace WindowsForm.Core.Controllers.Concrete.ValidatorControllers
{
    public static class FormValidationTool
    {
        public static bool IsValid(IValidator validator, object entity)
        {
           
            try
            {
                ValidationTool.Validate(validator, entity);
            }
            catch (ValidationException ex)
            {
                foreach (ValidationFailure failure in ex.Errors)
                {
                    FormsMessage.WarningMessage(failure.ErrorMessage);

                }
                return false;

            }
            return true;
        }
    }
}
