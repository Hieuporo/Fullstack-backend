using AutoMapper;
using MediatR;
using StoreProject.Application.Contracts.IReposiotry;
using StoreProject.Application.DTOs.ShippingMethod.Validators;
using StoreProject.Application.Exceptions;
using StoreProject.Application.ShippingMethods.Requests.Commands;
using StoreProject.Domain.Entities;

namespace StoreProject.Application.ShippingMethods.Handlers.Commands
{
    public class CreateShippingMethodCommandHandler : IRequestHandler<CreateShippingMethodCommand, int>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public CreateShippingMethodCommandHandler(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<int> Handle(CreateShippingMethodCommand request, CancellationToken cancellationToken)
        {
            var validator = new CreateShippingMethodDtoValidator();
            var validatorResult = await validator.ValidateAsync(request.ShippingMethodDto);

            if (validatorResult.IsValid == false)
            {
                throw new ValidationException(validatorResult);
            }
            var shippingMethod = _mapper.Map<ShippingMethod>(request.ShippingMethodDto);
            shippingMethod = await _unitOfWork.ShippingMethodRepository.Add(shippingMethod);
            await _unitOfWork.Save();

            return shippingMethod.Id;
        }
    }
}
