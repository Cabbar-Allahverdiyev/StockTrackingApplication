using Business.Constants.Messages;
using Core.CrossCuttingConcerns.Validation.Abstract;
using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.ValidationRules
{
    public class CustomerPaymentValidator:AbstractValidator<CustomerPayment>,IEntityValidator
    {
        public CustomerPaymentValidator()
        {
            RuleFor(c => c.CustomerId).NotEmpty();

            RuleFor(c => c.Value).NotEmpty();
            RuleFor(c => c.Value).NotNull();
            RuleFor(c => c.Value).GreaterThan(0).WithMessage(CustomerPaymentMessages.ValueMustBeGreaterThanZero);
            
            //RuleFor(c => c.Date).NotEmpty();
            //RuleFor(c => c.Date).NotNull();
        }
    }
}
