using AutoMapper;
using MediatR;
using StoreProject.Application.Contracts.Infrastructure.IReposiotry;
using StoreProject.Application.DTOs.CartItem.Validators;
using StoreProject.Application.Exceptions;
using StoreProject.Application.Features.CartItems.Requests.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreProject.Application.Features.CartItems.Handlers.Commands
{
    public class UpdateCartItemCommandHandler : IRequestHandler<UpdateCartItemCommand, Unit>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public UpdateCartItemCommandHandler(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<Unit> Handle(UpdateCartItemCommand request, CancellationToken cancellationToken)
        {
            var validator = new UpdateCartItemDtoValidator();
            var validatorResult = await validator.ValidateAsync(request.CartItemDto);

            if (validatorResult.IsValid == false)
            {
                throw new ValidationException(validatorResult);
            }

            var cartItem = await _unitOfWork.CartItemRepository.Get(request.CartItemDto.Id);

            _mapper.Map(request.CartItemDto, cartItem);


            await _unitOfWork.CartItemRepository.Update(cartItem);
            await _unitOfWork.Save();

            return Unit.Value;
        }
    }
}
