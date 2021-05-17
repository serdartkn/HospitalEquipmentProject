using Business.Constants;
using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.ValidationRules.FluentValidation
{
    //Doğrulama işlemleri için Fluent Validation kullanılmıştır.
    public class ClinicValidator : AbstractValidator<Clinic>
    {
        public ClinicValidator()
        {

            RuleFor(c => c.Name).NotEmpty().WithMessage(Messages.NotEmpty);
            RuleFor(c => c.Name).MinimumLength(2).WithMessage(Messages.MinLength2);
        }
    }
}