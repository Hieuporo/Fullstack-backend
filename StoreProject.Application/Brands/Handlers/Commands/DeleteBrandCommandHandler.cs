//using AutoMapper;
//using MediatR;
//using StoreProject.Application.Brands.Requests.Commands;
//using StoreProject.Application.Contracts.IReposiotry;


//namespace StoreProject.Application.Brands.Handlers.Commands
//{
//    public class DeleteBrandCommandHandler : IRequestHandler<DeleteBrandCommand>
//    {
//        private readonly IUnitOfWork _unitOfWork;
//        private readonly IMapper _mapper;

//        public DeleteBrandCommandHandler(IUnitOfWork unitOfWork, IMapper mapper)
//        {
//            _unitOfWork = unitOfWork;
//            _mapper = mapper;
//        }

//        public async Task<Unit> Handle(DeleteBrandCommand request, CancellationToken cancellationToken)
//        {

//            var brand = await _unitOfWork.BrandRepository.Get(request.Id);



//            await _unitOfWork.BrandRepository.Delete(brand);
//            await _unitOfWork.Save();

//            return Unit.Value;
//        }
//    }
//}
