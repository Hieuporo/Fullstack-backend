using FluentValidation;

namespace StoreProject.Application.Auth.Commands.CreatePassword
{
    public class CreatePasswordCommandValidator : AbstractValidator<CreatePasswordCommand>
    {
        public CreatePasswordCommandValidator()
        {

            RuleFor(p => p.Email)
                .NotNull().WithMessage("{PropertyName} is required")
                .EmailAddress().WithMessage("Please type a valid email");

            RuleFor(p => p.Password)
               .NotNull().WithMessage("{PropertyName} is required");

        }
    }
}
