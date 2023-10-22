using AutoMapper;
using MediatR;
using StoreProject.Application.Contracts.Infrastructure.IReposiotry;
using StoreProject.Application.DTOs.ProductTag.Validators;
using StoreProject.Application.Exceptions;
using StoreProject.Application.Features.ProductTags.Requests.Commands;
using StoreProject.Domain.Entities;

namespace StoreProject.Application.Features.ProductTags.Handlers.Commands
{
    public class CreateProductTagCommandHandler : IRequestHandler<CreateProductTagCommand>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public CreateProductTagCommandHandler(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<Unit> Handle(CreateProductTagCommand request, CancellationToken cancellationToken)
        {
            var validator = new CreateProductTagDtoValidator(_unitOfWork);
            var validatorResult = await validator.ValidateAsync(request.ProductTagDto);

            if (validatorResult.IsValid == false)
            {
                throw new ValidationException(validatorResult);
            }

            var isExist = await _unitOfWork.ProductTagRepository.GetProductTag(request.ProductTagDto.ProductId, request.ProductTagDto.TagId);


            if (isExist != null)
            {
                throw new BadRequestException("It already exists");
            }

            var productTag = _mapper.Map<ProductTag>(request.ProductTagDto);
            productTag = await _unitOfWork.ProductTagRepository.Add(productTag);
            await _unitOfWork.Save();

            return Unit.Value;
        }
    }
}
