using AutoMapper;
using MediatR;
using StoreProject.Application.Contracts.Authentication;
using StoreProject.Application.Contracts.IReposiotry;
using StoreProject.Application.DTOs.Cart;
using StoreProject.Application.Exceptions;
using StoreProject.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreProject.Application.Carts.Queries.GetCart
{
    public class GetCartQueryHandler : IRequestHandler<GetCartQuery, CartDto>
    {
        private readonly ICartRepository _cartRepository;
        private readonly IJwtService _jwtService;
        private readonly IMapper _mapper;

        public GetCartQueryHandler(ICartRepository cartRepository, IJwtService jwtService, IMapper mapper)
        {
            _cartRepository = cartRepository;
            _jwtService = jwtService;
            _mapper = mapper;
        }

        public async Task<CartDto> Handle(GetCartQuery request, CancellationToken cancellationToken)
        {
            var userId = _jwtService.GetCurrentUserId();

            var cart = await _cartRepository.GetCartByUserId(userId) ?? throw new BadRequestException("Something went wrong");

            return _mapper.Map<CartDto>(cart);
        }
    }
}
