using FluentValidation;
using StoreProject.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreProject.Application.DTOs.Order.Validators
{
    public class CreateOrderDtoValidator : AbstractValidator<CreateOrderDto>
    {
        public CreateOrderDtoValidator()
        {
            RuleFor(p => p.Address)
              .NotEmpty().WithMessage("{PropertyName} is required")
              .NotNull();

            RuleFor(p => p.UserId)
             .NotEmpty().WithMessage("{PropertyName} is required")
             .NotNull();

            RuleFor(p => p.Status)
              .NotEmpty().WithMessage("{PropertyName} is required")
              .NotNull();

            RuleFor(p => p.ShippingMethodId)
              .NotEmpty().WithMessage("{PropertyName} is required");

            RuleFor(p => p.StripeSessionId)
              .NotEmpty().WithMessage("{PropertyName} is required");

            RuleFor(p => p.Status)
              .NotEmpty().WithMessage("{PropertyName} is required")
              .NotNull();

            RuleFor(p => p.Discount)
              .NotEmpty().WithMessage("{PropertyName} is required");

            RuleFor(p => p.PhoneNumber)
              .NotEmpty().WithMessage("{PropertyName} is required");

            RuleFor(p => p.OrderTotal)
              .GreaterThan(0).WithMessage("{PropertyName} must be at least 1");
        }
    }
}
