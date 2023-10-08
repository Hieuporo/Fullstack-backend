using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreProject.Application.DTOs.ProductTag.Validators
{
    public class CreateProductTagDtoValidator : AbstractValidator<CreateProductTagDto>
    {
        public CreateProductTagDtoValidator()
        {
            RuleFor(p => p.ProductId)
                  .NotEmpty().WithMessage("{PropertyName} is required");

            RuleFor(p => p.TagId)
                   .NotNull().WithMessage("{PropertyName} is required");
        }
    }
}
