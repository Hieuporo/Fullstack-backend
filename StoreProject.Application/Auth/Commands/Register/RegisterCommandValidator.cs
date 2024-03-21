using FluentValidation;

namespace StoreProject.Application.Auth.Commands.Register
{
    public class RegisterCommandValidator : AbstractValidator<RegisterCommand>
    {
        public RegisterCommandValidator()
        {

            RuleFor(p => p.Email)
                .NotNull().WithMessage("{PropertyName} is required")
                .EmailAddress().WithMessage("Please type a valid email");
        }
    }
}
