using AutoMapper;
using MediatR;
using StoreProject.Application.Contracts.Infrastructure.IReposiotry;
using StoreProject.Application.DTOs.CartItem;
using StoreProject.Application.Features.CartItems.Requests.Queries;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreProject.Application.Features.CartItems.Handlers.Queries
{
    public class GetCartItemRequestHandler : IRequestHandler<GetCartItemRequest, CartItemDto>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public GetCartItemRequestHandler(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<CartItemDto> Handle(GetCartItemRequest request, CancellationToken cancellationToken)
        {

            var cartItem = await _unitOfWork.CartItemRepository.Get(request.Id);
            return _mapper.Map<CartItemDto>(cartItem);
        }
    }
}
