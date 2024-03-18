using AutoMapper;
using MediatR;
using StoreProject.Application.Categories.Requests.Commands;
using StoreProject.Application.Contracts.IReposiotry;
using StoreProject.Application.DTOs.Category.Validators;
using StoreProject.Application.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreProject.Application.Categories.Handlers.Commands
{
    public class UpdateCategoryCommandHandler : IRequestHandler<UpdateCategoryCommand, Unit>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public UpdateCategoryCommandHandler(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<Unit> Handle(UpdateCategoryCommand request, CancellationToken cancellationToken)
        {
            var validator = new UpdateCategoryDtoValidator();
            var validatorResult = await validator.ValidateAsync(request.CategoryDto);

            if (validatorResult.IsValid == false)
            {
                throw new ValidationException(validatorResult);
            }

            var category = await _unitOfWork.CategoryRepository.Get(request.CategoryDto.Id);

            _mapper.Map(request.CategoryDto, category);


            await _unitOfWork.CategoryRepository.Update(category);
            await _unitOfWork.Save();

            return Unit.Value;
        }
    }
}
