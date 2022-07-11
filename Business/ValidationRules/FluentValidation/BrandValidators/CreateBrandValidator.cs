using Core.CrossCuttingConcerns.Validation.Abstract;
using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.ValidationRules.FluentValidation.BrandValidators
{
    public class CreateBrandValidator : AbstractValidator<Brand>, IEntityValidator
    {
        public CreateBrandValidator()
        {
            RuleFor(b => b.BrandName).NotEmpty();
            RuleFor(b => b.BrandName).MinimumLength(2);
            RuleFor(b => b.BrandName).MaximumLength(40);

        }
    }
}
