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
using Microsoft.AspNetCore.Http;
using StoreProject.Application.Constants;
using StoreProject.Application.Exceptions;

namespace StoreProject.Application.Features.Orders.Handlers.Queries
{
    public class AdminGetOrderRequestHandler : IRequestHandler<AdminGetOrderRequest, OrderDto>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        public AdminGetOrderRequestHandler(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<OrderDto> Handle(AdminGetOrderRequest request, CancellationToken cancellationToken)
        {
            var order = _unitOfWork.OrderRepository.AdminGetOrderWithDetail(request.Id);

            if(order == null)
            {
                throw new BadRequestException("Order is not exist");
            }

            return _mapper.Map<OrderDto>(order);
        }
    }
}
