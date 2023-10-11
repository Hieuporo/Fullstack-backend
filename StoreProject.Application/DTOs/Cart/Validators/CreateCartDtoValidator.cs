using FluentValidation;
using StoreProject.Application.DTOs.Brand;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreProject.Application.DTOs.Cart.Validators
{
    public class CreateCartDtoValidator : AbstractValidator<CreateCartDto>
    {
        public CreateCartDtoValidator()
        {
            RuleFor(p => p.UserId)
               .NotEmpty().WithMessage("{PropertyName} is required")
               .NotNull();
        }
       


    }
}
