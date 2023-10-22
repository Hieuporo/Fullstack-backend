using FluentValidation;
using StoreProject.Application.Contracts.Infrastructure.IReposiotry;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreProject.Application.DTOs.ProductTag.Validators
{
    public class DeleteProductTagDtoValidator : AbstractValidator<DeleteProductTagDto>
    {
        private readonly IUnitOfWork _unitOfWork;

        public DeleteProductTagDtoValidator(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;

            RuleFor(p => p.ProductId)
            .MustAsync(async (id, token) => {
                    var leaveTypeExists = await _unitOfWork.ProductRepository.Exists(id);
                    return leaveTypeExists;
            }).WithMessage("{PropertyName} does not exist.")
            .NotEmpty().WithMessage("{PropertyName} is required");

            RuleFor(p => p.TagId)
            .MustAsync(async (id, token) => {
                    var leaveTypeExists = await _unitOfWork.TagRepository.Exists(id);
                    return leaveTypeExists;
            }).WithMessage("{PropertyName} does not exist.")
            .NotNull().WithMessage("{PropertyName} is required");
        }
    }
}
