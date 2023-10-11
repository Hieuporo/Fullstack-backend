//using AutoMapper;
//using MediatR;
//using StoreProject.Application.Contracts.Infrastructure.IReposiotry;
//using StoreProject.Application.DTOs.Hold.Validators;
//using StoreProject.Application.Exceptions;
//using StoreProject.Application.Features.Holds.Requests.Commands;
//using StoreProject.Domain.Entities;

//namespace StoreProject.Application.Features.Holds.Handlers.Commands
//{
//    public class CreateHoldCommandHandler : IRequestHandler<CreateHoldCommand, int>
//    {
//        private readonly IUnitOfWork _unitOfWork;
//        private readonly IMapper _mapper;

//        public CreateHoldCommandHandler(IUnitOfWork unitOfWork, IMapper mapper)
//        {
//            _unitOfWork = unitOfWork;
//            _mapper = mapper;
//        }

//        public async Task<int> Handle(CreateHoldCommand request, CancellationToken cancellationToken)
//        {
//            var validator = new CreateHoldDtoValidator();
//            var validatorResult = await validator.ValidateAsync(request.HoldDto);

//            if (validatorResult.IsValid == false)
//            {
//                throw new ValidationException(validatorResult);
//            }
//            var hold = _mapper.Map<Hold>(request.HoldDto);
//            hold = await _unitOfWork.HoldRepository.Add(hold);
//            await _unitOfWork.Save();

//            return hold.Id;
//        }
//    }
//}
