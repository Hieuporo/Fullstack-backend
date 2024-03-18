using AutoMapper;
using MediatR;
using StoreProject.Application.Contracts.IReposiotry;
using StoreProject.Application.DTOs.ProductItem.Validators;
using StoreProject.Application.Exceptions;
using StoreProject.Application.ProductItems.Requests.Commands;
using StoreProject.Domain.Entities;

namespace StoreProject.Application.ProductItems.Handlers.Commands
{
    public class CreateProductItemCommandHandler : IRequestHandler<CreateProductItemCommand, int>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public CreateProductItemCommandHandler(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<int> Handle(CreateProductItemCommand request, CancellationToken cancellationToken)
        {
            var validator = new CreateProductItemDtoValidator(_unitOfWork.ProductRepository);
            var validatorResult = await validator.ValidateAsync(request.ProductItemDto);

            if (validatorResult.IsValid == false)
            {
                throw new ValidationException(validatorResult);
            }
            var productItem = _mapper.Map<ProductItem>(request.ProductItemDto);
            productItem = await _unitOfWork.ProductItemRepository.Add(productItem);
            await _unitOfWork.Save();

            return productItem.Id;
        }
    }
}
