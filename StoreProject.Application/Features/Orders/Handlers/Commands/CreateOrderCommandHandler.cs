using AutoMapper;
using MediatR;
using StoreProject.Application.Contracts.Infrastructure.IReposiotry;
using StoreProject.Application.DTOs.Order.Validators;
using StoreProject.Application.Exceptions;
using StoreProject.Application.Features.Orders.Requests.Commands;
using StoreProject.Domain.Entities;

namespace StoreProject.Application.Features.Orders.Handlers.Commands
{
    public class CreateOrderCommandHandler : IRequestHandler<CreateOrderCommand, int>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public CreateOrderCommandHandler(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<int> Handle(CreateOrderCommand request, CancellationToken cancellationToken)
        {
            var validator = new CreateOrderDtoValidator();
            var validatorResult = await validator.ValidateAsync(request.OrderDto);

            if (validatorResult.IsValid == false)
            {
                throw new ValidationException(validatorResult);
            }
            var order = _mapper.Map<Order>(request.OrderDto);
            order = await _unitOfWork.OrderRepository.Add(order);
            await _unitOfWork.Save();

            return order.Id;
        }
    }
}
