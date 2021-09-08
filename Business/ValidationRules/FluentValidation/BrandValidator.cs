using Core.CrossCuttingConcerns.Validation.Abstract;
using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.ValidationRules.FluentValidation
{
    public class BrandValidator : AbstractValidator<Brand>, IEntityValidator
    {
        public BrandValidator()
        {
            RuleFor(b => b.BrandName).NotEmpty();
          
        }
    }
}
