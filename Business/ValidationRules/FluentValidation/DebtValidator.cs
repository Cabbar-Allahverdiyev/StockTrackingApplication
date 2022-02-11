using Core.CrossCuttingConcerns.Validation.Abstract;
using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.ValidationRules.FluentValidation
{
   public class DebtValidator:AbstractValidator<Debt>,IEntityValidator
    {
        public DebtValidator()
        {
            RuleFor(d => d.CustomerId).NotEmpty();
            RuleFor(d => d.CustomerId).GreaterThan(0);
            
            RuleFor(d => d.ProductId).NotEmpty();
            RuleFor(d => d.ProductId).GreaterThan(0);
            
            RuleFor(d => d.SoldPrice).NotEmpty();
            RuleFor(d => d.SoldPrice).GreaterThan(0);
            
            RuleFor(d => d.Quantity).NotEmpty();
            RuleFor(d => d.Quantity).GreaterThan(0);
        }
    }
}
