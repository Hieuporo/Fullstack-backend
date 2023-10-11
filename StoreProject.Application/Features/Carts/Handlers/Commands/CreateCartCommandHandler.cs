using AutoMapper;
using MediatR;
using StoreProject.Application.Contracts.Infrastructure.IReposiotry;
using StoreProject.Application.DTOs.Cart;
using StoreProject.Application.DTOs.Cart.Validators;
using StoreProject.Application.DTOs.Coupon.Validators;
using StoreProject.Application.Exceptions;
using StoreProject.Application.Features.Carts.Requests.Commands;
using StoreProject.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreProject.Application.Features.Carts.Handlers.Commands
{
    public class CreateCartCommandHandler : IRequestHandler<CreateCartCommand, int>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;


        public async Task<int> Handle(CreateCartCommand request, CancellationToken cancellationToken)
        {
            var cart = new Cart();
            cart.UserId = request.UserId;
            cart = await _unitOfWork.CartRepository.Add(cart);
            await _unitOfWork.Save();

            return cart.Id;
        }
    }
}
