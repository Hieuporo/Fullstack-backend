using MediatR;
using StoreProject.Application.Contracts.IReposiotry;
using StoreProject.Application.Exceptions;


namespace StoreProject.Application.ShippingMethods.Command.Delete
{
    public class DeleteShippingMethodCommandHandler : IRequestHandler<DeleteShippingMethodCommand, Unit>
    {
        public readonly IShippingMethodRepository _shippingMethodRepository;
        public readonly IUnitOfWork _unitOfWork;

        public DeleteShippingMethodCommandHandler(IShippingMethodRepository shippingMethodRepository, IUnitOfWork unitOfWork)
        {
            _shippingMethodRepository = shippingMethodRepository;
            _unitOfWork = unitOfWork;

        }

        public async Task<Unit> Handle(DeleteShippingMethodCommand request, CancellationToken cancellationToken)
        {
            var shippingMethod = await _shippingMethodRepository.Get(request.Id) ?? throw new BadRequestException("ShippingMethod does not exist.");
            await _shippingMethodRepository.Delete(shippingMethod);

            await _unitOfWork.SaveChangesAsync(cancellationToken);

            return Unit.Value;
        }
    }
}
