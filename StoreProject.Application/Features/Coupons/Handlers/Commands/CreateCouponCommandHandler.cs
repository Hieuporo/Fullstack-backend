using AutoMapper;
using MediatR;
using StoreProject.Application.Contracts.IReposiotry;
using StoreProject.Application.Coupons.Requests.Commands;
using StoreProject.Application.DTOs.Coupon;
using StoreProject.Application.DTOs.Coupon.Validators;
using StoreProject.Application.Exceptions;
using StoreProject.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreProject.Application.Coupons.Handlers.Commands
{
    public class CreateCouponCommandHandler : IRequestHandler<CreateCouponCommand, int>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public CreateCouponCommandHandler(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<int> Handle(CreateCouponCommand request, CancellationToken cancellationToken)
        {
            var validator = new CreateCouponDtoValidator();
            var validatorResult = await validator.ValidateAsync(request.CouponDto);

            if (validatorResult.IsValid == false)
            {
                throw new ValidationException(validatorResult);
            }

            var coupon = _mapper.Map<Coupon>(request.CouponDto);
            coupon = await _unitOfWork.CouponRepository.Add(coupon);
            await _unitOfWork.Save();

            var options = new Stripe.CouponCreateOptions
            {
                AmountOff = (long)(request.CouponDto.DiscountAmount * 100),
                Name = request.CouponDto.CouponCode,
                Currency = "usd",
                Id = request.CouponDto.CouponCode,
            };
            var service = new Stripe.CouponService();
            service.Create(options);



            return coupon.Id;
        }
    }
}
