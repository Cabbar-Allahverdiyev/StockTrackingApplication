using Core.CrossCuttingConcerns.Validation.Abstract;
using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.ValidationRules.FluentValidation.ProductValidators
{
    public class UpdateProductValidator : AbstractValidator<Product>, IEntityValidator
    {
        public UpdateProductValidator()
        {
            RuleFor(p => p.BarcodeNumber).NotEmpty();
            RuleFor(p => p.BarcodeNumber).Length(13);
            //RuleFor(p => p.BarcodeNumber).MinimumLength(13);
            //RuleFor(p => p.BarcodeNumber).MaximumLength(30);

            RuleFor(p => p.BrandId).NotEmpty();
            RuleFor(p => p.BrandId).GreaterThan(0);

            RuleFor(p => p.CategoryId).NotEmpty();
            RuleFor(p => p.CategoryId).GreaterThan(0);

            RuleFor(p => p.ProductName).NotEmpty();
            RuleFor(p => p.ProductName).MinimumLength(2);
            RuleFor(p => p.ProductName).MaximumLength(45);

            RuleFor(p => p.PurchasePrice).NotEmpty();

            RuleFor(p => p.QuantityPerUnit).NotEmpty();
            RuleFor(p => p.QuantityPerUnit).MinimumLength(2);
            RuleFor(p => p.QuantityPerUnit).MaximumLength(20);

            RuleFor(p => p.UnitPrice).NotEmpty();
            RuleFor(p => p.UnitPrice).GreaterThan(0);

            RuleFor(p => p.UnitsInStock).GreaterThanOrEqualTo(0);

            RuleFor(p => p.Description).MaximumLength(500);
        }
    }
}
