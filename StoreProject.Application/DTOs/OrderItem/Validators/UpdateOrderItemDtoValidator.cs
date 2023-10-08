using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreProject.Application.DTOs.OrderItem.Validators
{
    public class UpdateOrderItemDtoValidator : AbstractValidator<UpdateOrderItemDto>
    {
        public UpdateOrderItemDtoValidator()
        {
            RuleFor(p => p.ProductId)
          .NotEmpty().WithMessage("{PropertyName} is required")
          .NotNull();

            RuleFor(p => p.OrderId)
              .NotEmpty().WithMessage("{PropertyName} is required")
              .NotNull();

            RuleFor(p => p.Quantity)
              .NotEmpty().WithMessage("{PropertyName} is required")
              .GreaterThan(0).WithMessage("{PropertyName} must be at least 1");
        }
    }
}
