//using AutoMapper;
//using MediatR;
//using StoreProject.Application.Contracts.Infrastructure.IReposiotry;
//using StoreProject.Application.Features.Holds.Requests.Commands;
//using StoreProject.Application.Features.Coupons.Requests.Commands;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace StoreProject.Application.Features.Holds.Handlers.Commands
//{
//    public class DeleteHoldCommandHandler : IRequestHandler<DeleteHoldCommand>
//    {
//        private readonly IUnitOfWork _unitOfWork;
//        private readonly IMapper _mapper;

//        public DeleteHoldCommandHandler(IUnitOfWork unitOfWork, IMapper mapper)
//        {
//            _unitOfWork = unitOfWork;
//            _mapper = mapper;
//        }

//        public async Task<Unit> Handle(DeleteHoldCommand request, CancellationToken cancellationToken)
//        {

//            var hold = await _unitOfWork.HoldRepository.Get(request.Id);



//            await _unitOfWork.HoldRepository.Delete(hold);
//            await _unitOfWork.Save();

//            return Unit.Value;
//        }
//    }
//}
