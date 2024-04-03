using MediatR;
using StoreProject.Application.Contracts.Authentication;
using StoreProject.Application.Contracts.IReposiotry;
using StoreProject.Application.Exceptions;


namespace StoreProject.Application.Carts.Commands.DeleteCartItem
{
    public class DeleteCartItemCommandHandler : IRequestHandler<DeleteCartItemCommand, Unit>
    {
        private readonly ICartItemRepository _cartItemRepository;
        private readonly ICartRepository _cartRepository;
        private readonly IJwtService _jwtService;
        private readonly IUnitOfWork _unitOfWork;

        public DeleteCartItemCommandHandler(ICartItemRepository cartItemRepository, IJwtService jwtService, IUnitOfWork unitOfWork, ICartRepository cartRepository)
        {
            _cartItemRepository = cartItemRepository;
            _jwtService = jwtService;
            _unitOfWork = unitOfWork;
            _cartRepository = cartRepository;
        }

        public async Task<Unit> Handle(DeleteCartItemCommand request, CancellationToken cancellationToken)
        {

            var userId = _jwtService.GetCurrentUserId();

            var cart = await _cartRepository.GetCartByUserId(userId);

            var cartItem = await _cartItemRepository.Get(request.CartItemId);

            if (cartItem == null || cart.Id != cartItem.CartId)
            {
                throw new BadRequestException("Something went wrong");
            }

            await _cartItemRepository.Delete(cartItem);
            await _unitOfWork.SaveChangesAsync(cancellationToken);

            return Unit.Value;
        }
    }
}
