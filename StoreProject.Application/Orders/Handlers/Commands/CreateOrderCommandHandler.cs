//using AutoMapper;
//using MediatR;
//using Microsoft.AspNetCore.Http;
//using StoreProject.Application.Contracts.IReposiotry;
//using StoreProject.Application.Contracts.Service;
//using StoreProject.Application.DTOs.Order.Validators;
//using StoreProject.Application.Exceptions;
//using StoreProject.Application.Orders.Requests.Commands;
//using StoreProject.Domain.Entities;


//namespace StoreProject.Application.Orders.Handlers.Commands
//{
//    public class CreateOrderCommandHandler : IRequestHandler<CreateOrderCommand, int>
//    {
//        private readonly IUnitOfWork _unitOfWork;
//        private readonly IHttpContextAccessor _httpContextAccessor;
//        private readonly IEmailSender _emailSender;
//        private readonly IMapper _mapper;
//        public CreateOrderCommandHandler(
//            IUnitOfWork unitOfWork,
//            IMapper mapper,
//            IEmailSender emailSender,
//            IHttpContextAccessor httpContextAccessor
//        )
//        {
//            _unitOfWork = unitOfWork;
//            _mapper = mapper;
//            _httpContextAccessor = httpContextAccessor;
//            _emailSender = emailSender;
//        }

//        public async Task<int> Handle(CreateOrderCommand request, CancellationToken cancellationToken)
//        {
//            throw new NotImplementedException();
//        }
//    }
//}
