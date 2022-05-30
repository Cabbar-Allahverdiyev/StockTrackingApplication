using Core.CrossCuttingConcerns.Validation.Abstract;
using Entities.Concrete.ForForms;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.ValidationRules.FluentValidation
{
    public class SaleWinFormValidator : AbstractValidator<SaleWinForm>, IEntityValidator
    {
        public SaleWinFormValidator()
        {
            RuleFor(s => s.ProductId).NotEmpty();
            RuleFor(s => s.Quantity).NotEmpty();
            RuleFor(s => s.Quantity).GreaterThan(0);
        }
    }
}
