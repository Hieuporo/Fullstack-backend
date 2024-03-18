using AutoMapper;
using MediatR;
using Microsoft.AspNetCore.Http;
using StoreProject.Application.Carts.Requests.Commands;
using StoreProject.Application.Constants;
using StoreProject.Application.Contracts.IReposiotry;
using StoreProject.Application.DTOs.Cart;
using StoreProject.Application.Exceptions;
using StoreProject.Domain.Entities;
using System.Security.Claims;

namespace StoreProject.Application.Carts.Handlers.Commands
{
    public class CreateCartCommandHandler : IRequestHandler<CreateCartCommand, CartDto>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public CreateCartCommandHandler(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<CartDto> Handle(CreateCartCommand request, CancellationToken cancellationToken)
        {

            var cart = await _unitOfWork.CartRepository.CreateCart(request.UserId);

            await _unitOfWork.Save();

            return _mapper.Map<CartDto>(cart);
        }
    }
}
