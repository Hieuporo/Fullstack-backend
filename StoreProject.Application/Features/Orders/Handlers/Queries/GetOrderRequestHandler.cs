using AutoMapper;
using MediatR;
using StoreProject.Application.Contracts.Infrastructure.IReposiotry;
using StoreProject.Application.DTOs.Order;
using StoreProject.Application.DTOs.Coupon;
using StoreProject.Application.Features.Orders.Requests.Queries;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreProject.Application.Features.Orders.Handlers.Queries
{
    public class GetOrderRequestHandler : IRequestHandler<GetOrderRequest, OrderDto>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public GetOrderRequestHandler(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<OrderDto> Handle(GetOrderRequest request, CancellationToken cancellationToken)
        {
            var order = await _unitOfWork.OrderRepository.Get(request.Id);
            return _mapper.Map<OrderDto>(order);
        }
    }
}
