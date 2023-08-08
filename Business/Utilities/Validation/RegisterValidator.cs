using Business.Models.Request;
using FluentValidation;

namespace Business.Utilities.Validation;

public class RegisterValidator : AbstractValidator<RegisterDto>
{
    public RegisterValidator()
    {
        RuleFor(x => x.name).NotEmpty().WithName("name").MinimumLength(5);
        RuleFor(x => x.email).NotEmpty().WithName("email").EmailAddress();
        RuleFor(x => x.phone).NotEmpty().WithName("phone").MaximumLength(10);
        RuleFor(x => x.password).NotEmpty().WithName("password").MinimumLength(8);
    }
}