using Business.ValidationRules.FluentValidation;
using Core.Entities.Abstract;
using Core.Entities.Concrete;
using FluentValidation.Results;
using System;
using System.Collections.Generic;
using System.Text;
using WindowsForm.Core.Constants.Messages;
using WindowsForm.Core.Controllers.Abstract;

namespace WindowsForm.Core.Controllers.ValidatorControllers
{
    public  static class UserValidationTool
    {
        public static bool IsValid(User user)
        {
            UserValidator validationRules = new UserValidator();
            ValidationResult results = validationRules.Validate(user);

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
