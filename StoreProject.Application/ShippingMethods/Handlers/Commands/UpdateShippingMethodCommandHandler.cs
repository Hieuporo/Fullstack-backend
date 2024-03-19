//using AutoMapper;
//using MediatR;
//using StoreProject.Application.Contracts.IReposiotry;
//using StoreProject.Application.DTOs.ShippingMethod.Validators;
//using StoreProject.Application.Exceptions;
//using StoreProject.Application.ShippingMethods.Requests.Commands;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace StoreProject.Application.ShippingMethods.Handlers.Commands
//{
//    public class UpdateShippingMethodCommandHandler : IRequestHandler<UpdateShippingMethodCommand, Unit>
//    {
//        private readonly IUnitOfWork _unitOfWork;
//        private readonly IMapper _mapper;

//        public UpdateShippingMethodCommandHandler(IUnitOfWork unitOfWork, IMapper mapper)
//        {
//            _unitOfWork = unitOfWork;
//            _mapper = mapper;
//        }

//        public async Task<Unit> Handle(UpdateShippingMethodCommand request, CancellationToken cancellationToken)
//        {
//            //var validator = new UpdateShippingMethodDtoValidator();
//            //var validatorResult = await validator.ValidateAsync(request.ShippingMethodDto);

//            //if (validatorResult.IsValid == false)
//            //{
//            //    throw new ValidationException(validatorResult);
//            //}

//            //var shippingMethod = await _unitOfWork.ShippingMethodRepository.Get(request.ShippingMethodDto.Id);

//            //_mapper.Map(request.ShippingMethodDto, shippingMethod);


//            //await _unitOfWork.ShippingMethodRepository.Update(shippingMethod);
//            //await _unitOfWork.Save();

//            return Unit.Value;
//        }
//    }
//}
