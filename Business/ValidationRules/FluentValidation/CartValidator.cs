using Business.Constants.Messages;
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
            RuleFor(c => c.ProductId).NotEmpty();
            RuleFor(c => c.ProductId).GreaterThan(0);

            RuleFor(c => c.Quantity).NotEmpty();
            RuleFor(c => c.Quantity).GreaterThan(0);
            RuleFor(c => c.Quantity).Must(MustNotBeLessThanZero).WithMessage(CartMessages.QuantityMustBeGreaterThanZero);

            RuleFor(c => c.SoldPrice).NotEmpty();
            RuleFor(c => c.SoldPrice).GreaterThan(0);
            RuleFor(c => c.SoldPrice).Must(MustNotBeLessThanZero).WithMessage(CartMessages.QuantityMustBeGreaterThanZero);

            RuleFor(c => c.TotalPrice).NotEmpty();
            RuleFor(c => c.TotalPrice).GreaterThan(0);
            RuleFor(c => c.TotalPrice).Must(MustNotBeLessThanZero).WithMessage(CartMessages.QuantityMustBeGreaterThanZero);


        }

        private bool MustNotBeLessThanZero(int value)
        {
            return value > 0;
        }

        private bool MustNotBeLessThanZero(decimal value)
        {
            return value > 0;
        }
    }
}
