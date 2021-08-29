using eShopSolution.ViewModels.System.Users.Request;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eShopSolution.ViewModels.System.Users.Validation
{
    public class RegisterRequestValidator : AbstractValidator<RegisterRequest>
    {
        public RegisterRequestValidator()
        {
            RuleFor(x => x.UserName)
                .NotEmpty()
                .WithMessage("UserName is required");
            RuleFor(x => x.Password)
                .NotEmpty().WithMessage("Password is required")
                .MinimumLength(6).WithMessage("Password is at least 6 character");
            RuleFor(x => x.FirstName)
                .NotEmpty().WithMessage("FirstName is required")
                .MaximumLength(200).WithMessage("FirstName max length is 200");
            RuleFor(x => x.LastName)
                .NotEmpty().WithMessage("LastName is required")
                .MaximumLength(200).WithMessage("LastName max length is 200");
            RuleFor(x => x.DoB)
                .GreaterThan(DateTime.Now.AddYears(-100)).WithMessage("Birthday cannot greatter than 100 years");
            RuleFor(x => x.Email)
                .NotEmpty().WithMessage("Email is required")
                .Matches(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$").WithMessage("Email format not correct");
            RuleFor(x => x.PhoneNumber)
                .NotEmpty().WithMessage("PhoneNumber is required");

            RuleFor(x => x).Custom((request, context) =>
            {
                if (request.Password != request.ConfirmPassword)
                {
                    context.AddFailure("ConfirmPassword is not match with Password");
                }
            });
        }
    }
}