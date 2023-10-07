using AutoMapper;
using MediatR;
using StoreProject.Application.Contracts.Infrastructure.IReposiotry;
using StoreProject.Application.DTOs.Coupon.Validators;
using StoreProject.Application.Exceptions;
using StoreProject.Application.Features.Coupons.Requests.Commands;
using StoreProject.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreProject.Application.Features.Coupons.Handlers.Commands
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

            return coupon.Id;
        }
    }
}
