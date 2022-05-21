using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.ValidationRules.FluentValidation
{
    public class FormSettingValidator:AbstractValidator<FormSetting>
    {
        public FormSettingValidator()
        {
            RuleFor(s => s.Id).NotEmpty();
            RuleFor(s => s.Name).NotEmpty();
            
        }
    }
}
