using AutoMapper;
using MediatR;
using StoreProject.Application.Contracts.Authentication;
using StoreProject.Application.Contracts.IReposiotry;
using StoreProject.Application.DTOs.Coupon;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreProject.Application.Discounts.Requests.GetAvailableDiscounts
{
    public class GetAvailableDiscountsQueryHandler : IRequestHandler<GetAvailableDiscountsQuery, List<DiscountDto>>
    {
        private readonly IDiscountRepository _discountRepository;
        private readonly IJwtService _jwtService;
        private readonly IMapper _mapper;


        public GetAvailableDiscountsQueryHandler(IDiscountRepository discountRepository, IMapper mapper, IJwtService jwtService)
        {
            _discountRepository = discountRepository;
            _mapper = mapper;
            _jwtService = jwtService;
        }

        public async Task<List<DiscountDto>> Handle(GetAvailableDiscountsQuery request, CancellationToken cancellationToken)
        {
            var userId = _jwtService.GetCurrentUserId();
            var discounts = await _discountRepository.GetAvailableDiscounts(userId);

            return _mapper.Map<List<DiscountDto>>(discounts);
        }
    }
}
