using AutoMapper;
using MediatR;
using StoreProject.Application.Contracts.Infrastructure.IReposiotry;
using StoreProject.Application.DTOs.Order.Validators;
using StoreProject.Application.Exceptions;
using StoreProject.Application.Features.Orders.Requests.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreProject.Application.Features.Orders.Handlers.Commands
{
    public class UpdateOrderCommandHandler : IRequestHandler<UpdateOrderStatusCommand, Unit>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public UpdateOrderCommandHandler(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<Unit> Handle(UpdateOrderStatusCommand request, CancellationToken cancellationToken)
        {
            var validator = new UpdateOrderStatusDtoValidator();
            var validatorResult = await validator.ValidateAsync(request.OrderDto);

            if (validatorResult.IsValid == false)
            {
                throw new ValidationException(validatorResult);
            }

            var order = await _unitOfWork.OrderRepository.Get(request.OrderDto.Id);

            _mapper.Map(request.OrderDto, order);


            await _unitOfWork.OrderRepository.Update(order);
            await _unitOfWork.Save();

            return Unit.Value;
        }
    }
}
