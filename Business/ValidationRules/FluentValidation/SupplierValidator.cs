using Core.CrossCuttingConcerns.Validation.Abstract;
using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.ValidationRules.FluentValidation
{
    public class SupplierValidator : AbstractValidator<Supplier>, IEntityValidator
    {
        public SupplierValidator()
        {
            RuleFor(s => s.CompanyName).NotEmpty();
            RuleFor(s => s.CompanyName).MinimumLength(2);
            RuleFor(s => s.CompanyName).MaximumLength(50);

            RuleFor(s => s.ContactName).NotEmpty();
            RuleFor(s => s.ContactName).MinimumLength(4);
            RuleFor(s => s.ContactName).MaximumLength(50);

            RuleFor(s => s.Address).MaximumLength(100);

            RuleFor(s => s.City).MaximumLength(50);

            RuleFor(s => s.Email).MaximumLength(50);

            RuleFor(s => s.Phone).NotEmpty();
            RuleFor(s => s.Phone).MinimumLength(10);
            RuleFor(s => s.Phone).MaximumLength(14);

            RuleFor(s => s.WhenWillCome).MaximumLength(50);
        }
    }
}
