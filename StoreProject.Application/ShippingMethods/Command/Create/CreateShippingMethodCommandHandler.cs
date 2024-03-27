using AutoMapper;
using MediatR;
using StoreProject.Application.Contracts.IReposiotry;
using StoreProject.Domain.Entities;

namespace StoreProject.Application.ShippingMethods.Command.Create
{
    public class CreateShippingMethodCommandHandler : IRequestHandler<CreateShippingMethodCommand, int>
    {
        private readonly IShippingMethodRepository _shippingMethodRepository;
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public CreateShippingMethodCommandHandler(IShippingMethodRepository shippingMethodRepository, IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
            _shippingMethodRepository = shippingMethodRepository;
        }


        public async Task<int> Handle(CreateShippingMethodCommand request, CancellationToken cancellationToken)
        {
            var shippingMethod = await _shippingMethodRepository.Add(_mapper.Map<ShippingMethod>(request));

            await _unitOfWork.SaveChangesAsync(cancellationToken);

            return shippingMethod.Id;
        }
    }
}
