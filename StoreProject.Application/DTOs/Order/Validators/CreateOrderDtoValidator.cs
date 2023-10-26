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

            RuleFor(p => p.ShippingMethodId)
              .NotEmpty().WithMessage("{PropertyName} is required");

            RuleFor(p => p.PhoneNumber)
              .NotEmpty().WithMessage("{PropertyName} is required");

        }
    }
}
