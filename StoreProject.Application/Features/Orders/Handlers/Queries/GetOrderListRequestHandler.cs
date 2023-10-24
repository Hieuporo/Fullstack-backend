using AutoMapper;
using MediatR;
using StoreProject.Application.Contracts.Infrastructure.IReposiotry;
using StoreProject.Application.DTOs.Order;
using StoreProject.Application.DTOs.Coupon;
using StoreProject.Application.Features.Orders.Requests.Queries;
using StoreProject.Application.Features.Coupons.Requests.Queries;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreProject.Application.Features.Orders.Handlers.Queries
{
    public class GetOrderListRequestHandler : IRequestHandler<GetOrderListRequest, List<OrderDto>>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public GetOrderListRequestHandler(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<List<OrderDto>> Handle(GetOrderListRequest request, CancellationToken cancellationToken)
        {
            var orders = await _unitOfWork.OrderRepository.GetAll();
            return _mapper.Map<List<OrderDto>>(orders);
        }
    }
}
