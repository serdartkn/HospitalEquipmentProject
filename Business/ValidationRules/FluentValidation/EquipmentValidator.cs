using Business.Constants;
using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.ValidationRules.FluentValidation
{
    //Doğrulama işlemleri için Fluent Validation kullanılmıştır.
    public class EquipmentValidator : AbstractValidator<Equipment>
    {
        public EquipmentValidator()
        {
            RuleFor(e => e.Name).NotEmpty().WithMessage(Messages.NotEmpty);
            RuleFor(e => e.Name).MinimumLength(2).WithMessage(Messages.MinLength2);
            RuleFor(e => e.UnitsInStock).NotEmpty().WithMessage(Messages.NotEmpty); ;
            RuleFor(e => e.UnitsInStock).GreaterThanOrEqualTo(1).WithMessage(Messages.GreaterThan1);
            RuleFor(e => e.UnitsInStock).NotEmpty().WithMessage(Messages.NotEmpty); ;
            RuleFor(e => e.UnitPrice).Must(MinRule).WithMessage(Messages.GreaterThan001);
            RuleFor(e => e.ClinicId).NotEmpty().WithMessage(Messages.NotEmpty); ;
            RuleFor(e => e.UsageRate).Must(RangeRule).WithMessage(Messages.Range0100);
        }

        private bool MinRule(decimal arg)
        {

            return arg >= 0.01M;

        }

        private bool RangeRule(decimal arg)
        {

            return arg >= 0.00M && arg <= 100.0M;

        }
    }
}
