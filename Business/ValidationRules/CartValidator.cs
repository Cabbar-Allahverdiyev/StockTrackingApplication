using Core.CrossCuttingConcerns.Validation.Abstract;
using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.ValidationRules
{
    public class CartValidator : AbstractValidator<Sale>, IEntityValidator
    {
        public CartValidator()
        {
            RuleFor(c=>c.ProductId).NotEmpty();
         
          
        }
    }
}
