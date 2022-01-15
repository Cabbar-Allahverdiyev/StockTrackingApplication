using Core.CrossCuttingConcerns.Validation.Abstract;
using Core.Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.ValidationRules.FluentValidation
{
    public class UserValidator : AbstractValidator<User>,IEntityValidator
    {
        public UserValidator()
        {
            RuleFor(u => u.FirstName).NotEmpty().MinimumLength(4);
            RuleFor(u => u.LastName).NotEmpty().MinimumLength(4);
            RuleFor(u => u.Email).NotEmpty().MinimumLength(6);
            RuleFor(u => u.Email).EmailAddress();
            RuleFor(u => u.PhoneNumber).NotEmpty();
            RuleFor(u => u.PhoneNumber).MinimumLength(10);
            RuleFor(u => u.Address).NotEmpty();
           

        }
    }
}
