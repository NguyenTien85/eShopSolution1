﻿using eShopSolution.ViewModels.System.Users.Request;
using FluentValidation;

namespace eShopSolution.ViewModels.System.Users.Validation
{
    public class LoginRequestValidator : AbstractValidator<LoginRequest>
    {
        public LoginRequestValidator()
        {
            RuleFor(x => x.UserName)
                .NotEmpty()
                .WithMessage("UserName is required");
            RuleFor(x => x.Password)
                .NotEmpty().WithMessage("Password is required")
                .MinimumLength(6).WithMessage("Password is at least 6 character");
        }
    }
}