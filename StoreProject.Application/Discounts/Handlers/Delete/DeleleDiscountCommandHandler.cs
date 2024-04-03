using MediatR;
using StoreProject.Application.Contracts.IReposiotry;
using StoreProject.Application.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreProject.Application.Discounts.Handlers.Delete
{
    public class DeleleDiscountCommandHandler : IRequestHandler<DeleleDiscountCommand, Unit>
    {
        private readonly IDiscountRepository _discountRepository;
        private readonly IUnitOfWork _unitOfWork;

        public DeleleDiscountCommandHandler(IDiscountRepository discountRepository, IUnitOfWork unitOfWork)
        {
            _discountRepository = discountRepository;
            _unitOfWork = unitOfWork;
        }

        public async Task<Unit> Handle(DeleleDiscountCommand request, CancellationToken cancellationToken)
        {
            var discount = await _discountRepository.Get(request.Id);

            if (discount == null)
            {
                throw new BadRequestException("Discount does not exist.");
            }


            await _discountRepository.Delete(discount);

            await _unitOfWork.SaveChangesAsync(cancellationToken);

            return Unit.Value;
        }
    }
}
