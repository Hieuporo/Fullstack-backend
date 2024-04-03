using AutoMapper;
using MediatR;
using StoreProject.Application.Contracts.IReposiotry;
using StoreProject.Application.DTOs.Coupon;
using StoreProject.Application.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreProject.Application.Discounts.Requests.GetDiscountByCode
{
    public class GetDiscountByCodeQueryHandler : IRequestHandler<GetDiscountByCodeQuery, DiscountDto>
    {

        private readonly IDiscountRepository _discountRepository;
        private readonly IMapper _mapper;

        public GetDiscountByCodeQueryHandler(IDiscountRepository discountRepository, IMapper mapper)
        {
            _discountRepository = discountRepository;
            _mapper = mapper;
        }

        public async Task<DiscountDto> Handle(GetDiscountByCodeQuery request, CancellationToken cancellationToken)
        {
            var discount = await _discountRepository.GetDiscountByCode(request.DiscountCode);

            if (discount == null)
            {
                throw new BadRequestException("Discount does not exist");
            }

            return _mapper.Map<DiscountDto>(discount);
        }
    }
}
