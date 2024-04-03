using MediatR;
using StoreProject.Application.Contracts.Authentication;
using StoreProject.Application.Contracts.IReposiotry;
using StoreProject.Application.Exceptions;
using StoreProject.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreProject.Application.Carts.Commands.AddCartItem
{
    public class AddCartItemCommandHandler : IRequestHandler<AddCartItemCommand, Unit>
    {
        private readonly ICartRepository _cartRepository;
        private readonly ICartItemRepository _cartItemRepository;
        private readonly IProductRepository _productRepository;
        private readonly IJwtService _jwtService;
        private readonly IUnitOfWork _unitOfWork;

        public AddCartItemCommandHandler(ICartRepository cartRepository, IJwtService jwtService, IUnitOfWork unitOfWork, ICartItemRepository cartItemRepository, IProductRepository productRepository)
        {
            _cartRepository = cartRepository;
            _jwtService = jwtService;
            _unitOfWork = unitOfWork;
            _cartItemRepository = cartItemRepository;
            _productRepository = productRepository;
        }

        public async Task<Unit> Handle(AddCartItemCommand request, CancellationToken cancellationToken)
        {
            var userId = _jwtService.GetCurrentUserId();

            var cart = await _cartRepository.GetCartByUserId(userId);

            // create new cart if user doesnt have
            cart ??= await _cartRepository.CreateCart(userId);

            var cartItem = await _cartItemRepository.GetCartItem(cart.Id, request.ProductId);

            if(cartItem != null)
            {
                cartItem.Quantity = request.Quantity + cartItem.Quantity;
                await _cartItemRepository.Update(cartItem);
                await _unitOfWork.SaveChangesAsync(cancellationToken);
                return Unit.Value;
            }

            var product = await _productRepository.Get(request.ProductId) ?? throw new BadRequestException("Product does not exist");


            var newItem = new CartItem()
            {
                CartId = cart.Id,
                ProductId = request.ProductId,
                Quantity = request.Quantity

            };

            await _cartItemRepository.Add(newItem);
            await _unitOfWork.SaveChangesAsync(cancellationToken);

            return Unit.Value;

        }
    }
}
