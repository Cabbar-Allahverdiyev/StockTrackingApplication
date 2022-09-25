using Core.CrossCuttingConcerns.Validation.Abstract;
using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Constants.Messages
{
    public class BonusCardValidator :AbstractValidator<BonusCard>,IEntityValidator
    {
        public BonusCardValidator()
        {
            RuleFor(b=>b.CustomerId).NotEmpty();
            RuleFor(b=>b.CustomerId).GreaterThan(0);

            //RuleFor(b => b.BarcodeNumber).Length(9);
            RuleFor(b => b.BarcodeNumber).NotEmpty();

           // RuleFor(b => b.Balance).NotEmpty();
           
            //RuleFor(b=>b.InterestAdvantage).NotEmpty();
            //RuleFor(b=>b.InterestAdvantage).GreaterThan(0);
        }
    }
}
