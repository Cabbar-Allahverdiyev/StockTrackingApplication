using Business.Constants.Messages;
using Core.CrossCuttingConcerns.Validation.Abstract;
using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace Business.ValidationRules.FluentValidation
{
    public class CustomerValidator : AbstractValidator<Customer>, IEntityValidator
    {
        public CustomerValidator()
        {
            RuleFor(c => c.FirstName).NotEmpty();
            RuleFor(c => c.FirstName).MaximumLength(50);
            RuleFor(c => c.FirstName).MinimumLength(2);

            RuleFor(c => c.LastName).NotEmpty();
            RuleFor(c => c.LastName).MaximumLength(50);
            RuleFor(c => c.LastName).MinimumLength(2);

            RuleFor(c => c.PhoneNumber).NotEmpty();
            RuleFor(c => c.PhoneNumber).MaximumLength(14);
            RuleFor(c => c.PhoneNumber).MinimumLength(10);
            //bu format global ucundur   //RuleFor(c => c.PhoneNumber).Matches(new Regex(@"((\(\d{3}\) ?)|(\d{3}-))?\d{3}-\d{4}")).WithMessage(CustomerMessages.PhoneNumberNotValid);
            RuleFor(c => c.PhoneNumber).Matches(new Regex(@"^(0(\d{9}))$")).WithMessage(CustomerMessages.PhoneNumberNotValid);

            //RuleFor(c => c.Email).NotEmpty();
            RuleFor(c => c.Email).MaximumLength(50);
            //RuleFor(c => c.Email).EmailAddress();

            // RuleFor(c => c.Address).NotEmpty();
            RuleFor(c => c.Address).MaximumLength(100);

            //RuleFor(c => c.CreatedDate).NotEmpty();

        }
    }
}
