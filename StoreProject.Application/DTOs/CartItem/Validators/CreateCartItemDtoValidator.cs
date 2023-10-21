﻿using FluentValidation;
using StoreProject.Application.DTOs.Brand;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreProject.Application.DTOs.CartItem.Validators
{
    public class CreateCartItemDtoValidator : AbstractValidator<CreateCartItemDto>
    {
        public CreateCartItemDtoValidator()
        {
            RuleFor(p => p.UserId)
              .NotEmpty().WithMessage("{PropertyName} is required")
              .NotNull();

            RuleFor(p => p.ProductId)
              .NotEmpty().WithMessage("{PropertyName} is required")
              .NotNull();

            RuleFor(p => p.Quantity)
              .NotEmpty().WithMessage("{PropertyName} is required")
              .GreaterThan(0).WithMessage("{PropertyName} must be at least 1");

            RuleFor(p => p.Price)
              .NotEmpty().WithMessage("{PropertyName} is required")
              .GreaterThan(0).WithMessage("{PropertyName} must be at least 1");
        }
    }
}
