using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreProject.Application.DTOs.Product.Validators
{
    public class CreateProductDtoValidator : AbstractValidator<CreateProductDto>
    {
        public CreateProductDtoValidator()
        {
            RuleFor(p => p.Name)
                   .NotEmpty().WithMessage("{PropertyName} is required");

            RuleFor(p => p.Description)
                   .NotEmpty().WithMessage("{PropertyName} is required");

            RuleFor(p => p.CategoryId)
             .NotNull().WithMessage("{PropertyName} is required");

            RuleFor(p => p.BrandId)
             .NotNull().WithMessage("{PropertyName} is required");

            RuleFor(p => p.ImageUrl)
             .NotNull().WithMessage("{PropertyName} is required");
        }
    }
}
