using FluentValidation;


namespace StoreProject.Application.Auth.Commands.Login
{
    public class LoginCommandValidator : AbstractValidator<LoginCommand>
    {
        public LoginCommandValidator()
        {
            RuleFor(p => p.Email)
            .NotNull().WithMessage("{PropertyName} is required")
            .EmailAddress().WithMessage("Please type a valid email");

            RuleFor(p => p.Password)
               .NotNull().WithMessage("{PropertyName} is required");

        }
    }
}
