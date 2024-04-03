using MediatR;
using StoreProject.Application.Contracts.Authentication;
using StoreProject.Application.Contracts.IReposiotry;
using StoreProject.Application.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreProject.Application.Carts.Commands.PlusProduct
{
    public class PlusProductCommandHandler : IRequestHandler<PlusProductCommand, Unit>
    {
        private readonly ICartItemRepository _cartItemRepository;
        private readonly ICartRepository _cartRepository;
        private readonly IJwtService _jwtService;
        private readonly IUnitOfWork _unitOfWork;

        public PlusProductCommandHandler(ICartItemRepository cartItemRepository, ICartRepository cartRepository, IJwtService jwtService, IUnitOfWork unitOfWork)
        {
            _cartItemRepository = cartItemRepository;
            _cartRepository = cartRepository;
            _jwtService = jwtService;
            _unitOfWork = unitOfWork;
        }

        public async Task<Unit> Handle(PlusProductCommand request, CancellationToken cancellationToken)
        {
            var userId = _jwtService.GetCurrentUserId();

            var cart = await _cartRepository.GetCartByUserId(userId) ?? throw new BadRequestException("Something went wrong");


            var cartItem = await _cartItemRepository.GetCartItem(cart.Id, request.ProductId) ?? throw new BadRequestException("Something went wrong");

            if (cartItem.Quantity > 0)
            {
                cartItem.Quantity += 1;
            }

            await _cartItemRepository.Update(cartItem);
            await _unitOfWork.SaveChangesAsync(cancellationToken);

            return Unit.Value;
        }
    }
}
