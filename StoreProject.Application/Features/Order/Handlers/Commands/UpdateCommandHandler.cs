//using AutoMapper;
//using MediatR;
//using StoreProject.Application.Contracts.Infrastructure.IReposiotry;
//using StoreProject.Application.DTOs.Hold.Validators;
//using StoreProject.Application.Exceptions;
//using StoreProject.Application.Features.Holds.Requests.Commands;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace StoreProject.Application.Features.Holds.Handlers.Commands
//{
//    public class UpdateHoldCommandHandler : IRequestHandler<UpdateHoldCommand, Unit>
//    {
//        private readonly IUnitOfWork _unitOfWork;
//        private readonly IMapper _mapper;

//        public UpdateHoldCommandHandler(IUnitOfWork unitOfWork, IMapper mapper)
//        {
//            _unitOfWork = unitOfWork;
//            _mapper = mapper;
//        }

//        public async Task<Unit> Handle(UpdateHoldCommand request, CancellationToken cancellationToken)
//        {
//            var validator = new UpdateHoldDtoValidator();
//            var validatorResult = await validator.ValidateAsync(request.HoldDto);

//            if (validatorResult.IsValid == false)
//            {
//                throw new ValidationException(validatorResult);
//            }

//            var hold = await _unitOfWork.HoldRepository.Get(request.HoldDto.Id);

//            _mapper.Map(request.HoldDto, hold);


//            await _unitOfWork.HoldRepository.Update(hold);
//            await _unitOfWork.Save();

//            return Unit.Value;
//        }
//    }
//}
