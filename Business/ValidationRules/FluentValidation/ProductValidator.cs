using Core.CrossCuttingConcerns.Validation.Abstract;
using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.ValidationRules.FluentValidation
{
    public class ProductValidator : AbstractValidator<Product>, IEntityValidator
    {
        public ProductValidator()
        {
            RuleFor(p => p.BarcodeNumber).NotEmpty();
            RuleFor(p => p.BarcodeNumber).MinimumLength(13);
            RuleFor(p => p.BarcodeNumber).MaximumLength(30);
            RuleFor(p => p.BrandId).NotEmpty();
            RuleFor(p => p.BrandId).GreaterThan(0);
            RuleFor(p => p.CategoryId).NotEmpty();
            RuleFor(p => p.CategoryId).GreaterThan(0);
            RuleFor(p => p.ProductName).NotEmpty();
            RuleFor(p => p.ProductName).MinimumLength(2);
            RuleFor(p => p.ProductName).MaximumLength(45);
            RuleFor(p => p.PurchasePrice).NotEmpty();
            RuleFor(p => p.QuantityPerUnit).NotEmpty();
            RuleFor(p => p.UnitPrice).NotEmpty();
            RuleFor(p => p.UnitPrice).GreaterThan(0);
            RuleFor(p => p.UnitsInStock).NotEmpty();
            RuleFor(p => p.Description).MaximumLength(500);
        }
    }
}
