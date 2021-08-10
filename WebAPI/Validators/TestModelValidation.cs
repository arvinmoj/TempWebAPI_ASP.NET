using System;
using FluentValidation;

namespace Validator
{
    public class TestModelValidation : AbstractValidator<ViewModels.TestModelVM>
    {
        [Obsolete]
        public TestModelValidation()
        {
            // *****
            RuleFor(c => c.FullName)
                .NotNull().WithMessage(errorMessage: "FullName Is Required")
                .NotEmpty()
                .MinimumLength(3).WithMessage(errorMessage: "Minimum Length 3")
                .MaximumLength(20).WithMessage(errorMessage: "Maximum Length 20");
            // *****

            // *****
            RuleFor(c => c.Age)
               .NotNull().WithMessage(errorMessage: "Age Is Required")
               .NotEmpty();
            // *****

            // *****
            RuleFor(c => c.PhoneNumber)
                .NotNull().WithMessage(errorMessage: "PhoneNumber Is Required")
                .NotEmpty()
                .Length(11).WithMessage(errorMessage: "Checking Length 12");
            // *****
        }
    }
}