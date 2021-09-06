
using Core.CrossCuttingConcerns.Validation.Abstract;
using Core.Entities.Abstract;
using FluentValidation;
using FluentValidation.Results;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.ValidationRules.ValidateIntegrated
{
    public class WindowsFormsValidate<TValidator,TEntity>
        where TValidator:class,IEntityValidator,new()
        where TEntity:class,IEntity,new()
       
    {
        //TValidator validationRules = new TValidator();

        //public string ValidateMessages(TEntity entity,)
        //{
        //    ValidationResult results = validationRules.Validate(entity);

        //    return;
        //}


        //TValidator validationRules = new TValidator();
        //ValidationResult results = validationRules.Validate(user);

        //    if (results.IsValid == false)
        //    {
        //        foreach (ValidationFailure failure in results.Errors)
        //        {
        //            //errors.Add($"{failure.PropertyName}:{failure.ErrorMessage}");
        //            MessageBox.Show(failure.ErrorMessage);

        //        }
        //        return;

        //    }
    }
}
