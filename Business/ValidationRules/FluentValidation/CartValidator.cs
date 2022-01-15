using Core.CrossCuttingConcerns.Validation.Abstract;
using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.ValidationRules.FluentValidation
{
    public class CartValidator : AbstractValidator<Cart>, IEntityValidator
    {
        public CartValidator()
        {
            RuleFor(c=>c.ProductId).NotEmpty();
            RuleFor(c=>c.Quantity).NotEmpty();
            RuleFor(c=>c.SoldPrice).NotEmpty();
            RuleFor(c=>c.TotalPrice).NotEmpty();
         
          
        }
    }
}
