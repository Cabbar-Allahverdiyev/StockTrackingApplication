using Core.CrossCuttingConcerns.Validation.Abstract;
using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.ValidationRules.FluentValidation.CategoryValidators
{
    public class CreateCategoryValidator : AbstractValidator<Category>, IEntityValidator
    {
        public CreateCategoryValidator()
        {
           // RuleFor(c => c.Id).Null();
            RuleFor(c => c.CategoryName).NotEmpty();
            RuleFor(c => c.CategoryName).MinimumLength(2);
            RuleFor(c => c.CategoryName).MaximumLength(40);
        }
    }
}
