using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreProject.Application.DTOs.ProductItem.Validators
{
    public class CreateProductItemDtoValidator : AbstractValidator<CreateProductItemDto>
    {
        public CreateProductItemDtoValidator()
        {
            RuleFor(p => p.ProductId)
                   .NotEmpty().WithMessage("{PropertyName} is required");

            RuleFor(p => p.QuantityInStock)
                   .NotNull().WithMessage("{PropertyName} is required");

            RuleFor(p => p.ImageUrl)
             .NotNull().WithMessage("{PropertyName} is required");

            RuleFor(p => p.Price)
             .NotNull().WithMessage("{PropertyName} is required")
             .GreaterThan(0).WithMessage("{PropertyName} must be greater than 0");

        }
    }
}
