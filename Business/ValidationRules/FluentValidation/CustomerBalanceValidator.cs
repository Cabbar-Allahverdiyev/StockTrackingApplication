using Business.Constants.Messages;
using Core.CrossCuttingConcerns.Validation.Abstract;
using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.ValidationRules.FluentValidation
{
    public class CustomerBalanceValidator:AbstractValidator<CustomerBalance>,IEntityValidator
    {
        public CustomerBalanceValidator()
        {
            RuleFor(c => c.CustomerId).NotEmpty();
            RuleFor(c => c.CustomerId).GreaterThan(0);
            
            //RuleFor(c => c.Debt).NotEmpty();
            //RuleFor(c => c.Debt).Must(MustNotBeLessThanZero).WithMessage(CustomerBalanceMessages.DebtMustBeGreaterThanZero);

            //RuleFor(c => c.Balance).NotEmpty();
            //RuleFor(c => c.Debt).Must(MustNotBeLessThanZero).WithMessage(CustomerBalanceMessages.BalanceMustBeGreaterThanZero);

           // RuleFor(c => c.DateOfLastLoan).NotEmpty();
            RuleFor(c => c.DateOfLastLoan).GreaterThanOrEqualTo(DateTime.Now);
        }

        
    }
}
