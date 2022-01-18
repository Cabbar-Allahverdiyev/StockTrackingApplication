using Core.CrossCuttingConcerns.Validation.Abstract;
using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.ValidationRules.FluentValidation
{
    public class SaleValidator : AbstractValidator<Sale>, IEntityValidator
    {
        public SaleValidator()
        {
            RuleFor(s=>s.ProductId).NotEmpty();
            RuleFor(s=>s.SoldPrice).NotEmpty();
            RuleFor(s=>s.Quantity).NotEmpty();
          
        }
    }
}
