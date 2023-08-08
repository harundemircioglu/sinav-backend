using Business.Models.Request;
using FluentValidation;

namespace Business.Utilities.Validation;

public class LoginValidator : AbstractValidator<LoginDto>
{
    public LoginValidator()
    {
        RuleFor(x => x.email).NotEmpty().WithName("email");
        RuleFor(x => x.password).NotEmpty().WithName("password");
    }
}