using AutoMapper;
using MediatR;
using StoreProject.Application.DTOs.Order;
using StoreProject.Application.DTOs.Coupon;
using StoreProject.Application.Features.Coupons.Requests.Queries;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using System.Security.Claims;
using StoreProject.Application.Constants;
using StoreProject.Application.Orders.Requests.Queries;
using StoreProject.Application.Contracts.IReposiotry;

namespace StoreProject.Application.Orders.Handlers.Queries
{
    public class AdminGetOrderListRequestHandler : IRequestHandler<AdminGetOrderListRequest, List<OrderDto>>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        private readonly IHttpContextAccessor _httpContextAccessor;
        public AdminGetOrderListRequestHandler(IUnitOfWork unitOfWork, IMapper mapper, IHttpContextAccessor httpContextAccessor)
        {
            _unitOfWork = unitOfWork;
            _httpContextAccessor = httpContextAccessor;
            _mapper = mapper;
        }


        public async Task<List<OrderDto>> Handle(AdminGetOrderListRequest request, CancellationToken cancellationToken)
        {
            var userId = _httpContextAccessor.HttpContext.User.FindFirst(CustomClaimTypes.Uid).Value;

            var orders = _unitOfWork.OrderRepository.GetAllOrdersWithDetail();


            return _mapper.Map<List<OrderDto>>(orders);
        }
    }
}
