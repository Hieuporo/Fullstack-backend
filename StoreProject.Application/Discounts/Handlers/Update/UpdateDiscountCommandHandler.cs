using AutoMapper;
using MediatR;
using StoreProject.Application.Contracts.IReposiotry;
using StoreProject.Application.Exceptions;
using StoreProject.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreProject.Application.Discounts.Handlers.Update
{
    public class UpdateDiscountCommandHandler : IRequestHandler<UpdateDiscountCommand, Unit>
    {
        public readonly IDiscountRepository _discountRepository;
        public readonly IMapper _mapper;
        public readonly IUnitOfWork _unitOfWork;

        public UpdateDiscountCommandHandler(IDiscountRepository discountRepository, IUnitOfWork unitOfWork, IMapper mapper)
        {
            _discountRepository = discountRepository;
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<Unit> Handle(UpdateDiscountCommand request, CancellationToken cancellationToken)
        {
            var discount = await _discountRepository.Get(request.Id);

            if (discount == null)
            {
                throw new BadRequestException("discount does not exist.");
            }

            await _discountRepository.Update(_mapper.Map<Discount>(request));

            await _unitOfWork.SaveChangesAsync(cancellationToken);

            return Unit.Value;
        }
    }
}
