using Core.CrossCuttingConcerns.Validation.Abstract;
using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.ValidationRules.FluentValidation.CategoryValidators
{
    public  class UpdateCategoryValidator : AbstractValidator<Category>, IEntityValidator
    {
        public UpdateCategoryValidator()
        {
            RuleFor(c => c.Id).NotEmpty();
            RuleFor(c => c.Id).NotNull();

            RuleFor(c => c.CategoryName).NotEmpty();
            RuleFor(c => c.CategoryName).MinimumLength(2);
            RuleFor(c => c.CategoryName).MaximumLength(40);
        }
    }
}
