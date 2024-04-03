using AutoMapper;
using MediatR;
using StoreProject.Application.Contracts.IReposiotry;
using StoreProject.Application.Utils;
using StoreProject.Domain.Entities;


namespace StoreProject.Application.Discounts.Handlers.Create
{
    public class CreateDiscountCommandHandler : IRequestHandler<CreateDiscountCommand, int>
    {
        private readonly IDiscountRepository _discountRepository;
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;


        public CreateDiscountCommandHandler(IDiscountRepository discountRepository, IUnitOfWork unitOfWork, IMapper mapper)
        {
            _discountRepository = discountRepository;
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<int> Handle(CreateDiscountCommand request, CancellationToken cancellationToken)
        {
            var discount = _mapper.Map<Discount>(request);
            discount.UsesCount = 0;

            await _discountRepository.Add(discount);
            await _unitOfWork.SaveChangesAsync(cancellationToken);
            return discount.Id;
        }
    }
}
