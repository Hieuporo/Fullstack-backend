using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreProject.Application.DTOs.CartItem.Validators
{
    public class UpdateCartItemDtoValidator : AbstractValidator<UpdateCartItemDto>
    {
        public UpdateCartItemDtoValidator()
        {
            RuleFor(p => p.CartId)
           .NotEmpty().WithMessage("{PropertyName} is required")
           .NotNull();

            RuleFor(p => p.ProductId)
              .NotEmpty().WithMessage("{PropertyName} is required")
              .NotNull();

            RuleFor(p => p.Quantity)
              .NotEmpty().WithMessage("{PropertyName} is required")
              .GreaterThan(0).WithMessage("{PropertyName} must be at least 1");
        }
    }
}
