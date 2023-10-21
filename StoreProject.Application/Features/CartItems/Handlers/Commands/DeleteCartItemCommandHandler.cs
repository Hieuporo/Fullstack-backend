using AutoMapper;
using MediatR;
using StoreProject.Application.Contracts.Infrastructure.IReposiotry;
using StoreProject.Application.Features.CartItems.Requests.Commands;
using StoreProject.Application.Features.Coupons.Requests.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreProject.Application.Features.CartItems.Handlers.Commands
{
    public class DeleteCartItemCommandHandler : IRequestHandler<DeleteCartItemCommand>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public DeleteCartItemCommandHandler(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<Unit> Handle(DeleteCartItemCommand request, CancellationToken cancellationToken)
        {

            var cartItem = await _unitOfWork.CartItemRepository.Get(request.Id);



            await _unitOfWork.CartItemRepository.Delete(cartItem);
            await _unitOfWork.Save();

            return Unit.Value;
        }
    }
}
