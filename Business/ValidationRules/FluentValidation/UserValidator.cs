using Core.CrossCuttingConcerns.Validation.Abstract;
using Core.Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.ValidationRules.FluentValidation
{
    public class UserValidator : AbstractValidator<User>, IEntityValidator
    {
        public UserValidator()
        {
            RuleFor(u => u.FirstName).NotEmpty();
            RuleFor(u => u.FirstName).MinimumLength(4);
            RuleFor(u => u.FirstName).MaximumLength(40);

            RuleFor(u => u.LastName).NotEmpty();
            RuleFor(u => u.LastName).MinimumLength(4);
            RuleFor(u => u.LastName).MaximumLength(40);

            RuleFor(u => u.Email).NotEmpty();
            RuleFor(u => u.Email).MinimumLength(6);
            RuleFor(u => u.Email).MaximumLength(40);
            RuleFor(u => u.Email).EmailAddress();

            RuleFor(u => u.PhoneNumber).NotEmpty();
            RuleFor(u => u.PhoneNumber).MinimumLength(10);
            RuleFor(u => u.PhoneNumber).MaximumLength(14);

            RuleFor(u => u.Address).NotEmpty();
            RuleFor(u => u.Address).MinimumLength(4);
            RuleFor(u => u.Address).MaximumLength(40);
        }
    }
}
