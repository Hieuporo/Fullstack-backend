using MediatR;
using Microsoft.AspNetCore.Http;
using StoreProject.Application.Contracts.IReposiotry;
using StoreProject.Application.Exceptions;
using StoreProject.Application.Orders.Requests.Commands;
using StoreProject.Domain.Entities;


namespace StoreProject.Application.Orders.Handlers.Commands
{
    public class CreateCheckoutSessionCommandHandler : IRequestHandler<CreateCheckoutSessionCommand, string>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IHttpContextAccessor _httpContextAccessor;
        public CreateCheckoutSessionCommandHandler(
            IUnitOfWork unitOfWork,
            IHttpContextAccessor httpContextAccessor
            )
        {

            _unitOfWork = unitOfWork;
            _httpContextAccessor = httpContextAccessor;
        }

        public async Task<string> Handle(CreateCheckoutSessionCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
