using AutoMapper;
using MediatR;
using StoreProject.Application.CartItems.Requests.Commands;
using StoreProject.Application.Contracts.IReposiotry;
using StoreProject.Application.DTOs.CartItem.Validators;
using StoreProject.Application.Exceptions;
using StoreProject.Domain.Entities;

namespace StoreProject.Application.CartItems.Handlers.Commands
{
    public class CreateCartItemCommandHandler : IRequestHandler<CreateCartItemCommand, int>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public CreateCartItemCommandHandler(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<int> Handle(CreateCartItemCommand request, CancellationToken cancellationToken)
        {
            var validator = new CreateCartItemDtoValidator();
            var validatorResult = await validator.ValidateAsync(request.CartItemDto);

            if (validatorResult.IsValid == false)
            {
                throw new ValidationException(validatorResult);
            }



            var cartItemExist = await _unitOfWork.CartItemRepository
                .GetCartItem(request.CartItemDto.CartId, request.CartItemDto.ProductItemId);

            if (cartItemExist != null)
            {
                cartItemExist.Quantity = request.CartItemDto.Quantity + cartItemExist.Quantity;
                await _unitOfWork.CartItemRepository.Update(cartItemExist);
                await _unitOfWork.Save();
                return cartItemExist.Id;
            }

            var cartItem = _mapper.Map<CartItem>(request.CartItemDto);
            cartItem = await _unitOfWork.CartItemRepository.Add(cartItem);
            await _unitOfWork.Save();

            return cartItem.Id;
        }
    }
}
