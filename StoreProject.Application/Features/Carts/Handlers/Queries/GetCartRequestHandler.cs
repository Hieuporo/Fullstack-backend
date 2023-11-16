using AutoMapper;
using MediatR;
using Microsoft.AspNetCore.Http;
using StoreProject.Application.Constants;
using StoreProject.Application.Contracts.Infrastructure.IReposiotry;
using StoreProject.Application.DTOs.Cart;
using StoreProject.Application.DTOs.Coupon;
using StoreProject.Application.Features.Carts.Requests.Queries;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreProject.Application.Features.Cart.Handlers.Queries
{
    public class GetCartRequestHandler : IRequestHandler<GetCartRequest, CartDto>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        private readonly IHttpContextAccessor _httpContextAccessor;

        public GetCartRequestHandler(IUnitOfWork unitOfWork, IMapper mapper, IHttpContextAccessor httpContextAccessor)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
            _httpContextAccessor = httpContextAccessor;

        }

        public async Task<CartDto> Handle(GetCartRequest request, CancellationToken cancellationToken)
        {
            var userId = _httpContextAccessor.HttpContext.User.FindFirst(CustomClaimTypes.Uid).Value;


            var cart = await _unitOfWork.CartRepository.GetCartByUserId(userId);
            return _mapper.Map<CartDto>(cart);
        }
    }
}
