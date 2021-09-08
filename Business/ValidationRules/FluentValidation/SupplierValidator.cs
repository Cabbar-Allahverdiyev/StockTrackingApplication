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
            RuleFor(s=>s.CompanyName).NotEmpty();
            RuleFor(s=>s.ContactName).NotEmpty();
           
        }
    }
}
