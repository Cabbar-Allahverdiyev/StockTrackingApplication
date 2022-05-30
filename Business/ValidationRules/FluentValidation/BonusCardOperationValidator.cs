using Core.CrossCuttingConcerns.Validation.Abstract;
using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.ValidationRules.FluentValidation
{
    public class BonusCardOperationValidator:AbstractValidator<BonusCardOperation>,IEntityValidator
    {
        public BonusCardOperationValidator()
        {
            RuleFor(o => o.BonusCardId).NotEmpty();
            RuleFor(o => o.Value).NotEmpty();
            RuleFor(o => o.Value).GreaterThan(0);
            RuleFor(o => o.UserId).NotEmpty();


        }
    }
}
