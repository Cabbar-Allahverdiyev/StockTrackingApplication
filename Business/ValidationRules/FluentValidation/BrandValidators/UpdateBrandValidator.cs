using Core.CrossCuttingConcerns.Validation.Abstract;
using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.ValidationRules.FluentValidation.BrandValidators
{
    public class UpdateBrandValidator : AbstractValidator<Brand>, IEntityValidator
    {
        public UpdateBrandValidator()
        {
            RuleFor(b => b.Id).NotEmpty();
            RuleFor(b => b.Id).NotNull();

            RuleFor(b => b.BrandName).NotEmpty();
            RuleFor(b => b.BrandName).MinimumLength(2);
            RuleFor(b => b.BrandName).MaximumLength(40);

        }
    }
}
