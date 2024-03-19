using AutoMapper;
using MediatR;
using Microsoft.AspNetCore.Http;
using StoreProject.Application.CartItems.Requests.Commands;
using StoreProject.Application.Contracts.IReposiotry;
using StoreProject.Application.Exceptions;

namespace StoreProject.Application.CartItems.Handlers.Commands
{
    public class DeleteCartItemCommandHandler : IRequestHandler<DeleteCartItemCommand>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        private readonly IHttpContextAccessor _httpContextAccessor;
        public DeleteCartItemCommandHandler(IUnitOfWork unitOfWork, IMapper mapper, IHttpContextAccessor httpContextAccessor)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
            _httpContextAccessor = httpContextAccessor;
        }

        public async Task<Unit> Handle(DeleteCartItemCommand request, CancellationToken cancellationToken)
        {
            //var userId = _httpContextAccessor.HttpContext.User.FindFirst(CustomClaimTypes.Uid).Value;

            //if (!await _unitOfWork.CartItemRepository.IsItemOwnedByUser(request.Id, userId))
            //{
            //    throw new BadRequestException("Something went wrong");
            //}

            //var cartItem = await _unitOfWork.CartItemRepository.Get(request.Id);


            //await _unitOfWork.CartItemRepository.Delete(cartItem);
            //await _unitOfWork.Save();

            return Unit.Value;
        }
    }
}
