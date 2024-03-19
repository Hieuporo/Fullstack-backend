using AutoMapper;
using MediatR;
using StoreProject.Application.Contracts.IReposiotry;
using StoreProject.Application.Coupons.Requests.Commands;
using StoreProject.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreProject.Application.Coupons.Handlers.Commands
{
    public class DeleteCouponCommandHandler : IRequestHandler<DeleteCouponCommand>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public DeleteCouponCommandHandler(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<Unit> Handle(DeleteCouponCommand request, CancellationToken cancellationToken)
        {

            //var coupon = await _unitOfWork.CouponRepository.Get(request.Id);



            //await _unitOfWork.CouponRepository.Delete(coupon);
            //await _unitOfWork.Save();

            return Unit.Value;
        }
    }
}
