//using AutoMapper;
//using MediatR;
//using StoreProject.Application.Categories.Requests.Commands;
//using StoreProject.Application.Contracts.IReposiotry;
//using StoreProject.Application.DTOs.Category.Validators;
//using StoreProject.Application.Exceptions;
//using StoreProject.Domain.Entities;

//namespace StoreProject.Application.Categories.Handlers.Commands
//{
//    public class CreateCategoryCommandHandler : IRequestHandler<CreateCategoryCommand, int>
//    {
//        private readonly IUnitOfWork _unitOfWork;
//        private readonly IMapper _mapper;

//        public CreateCategoryCommandHandler(IUnitOfWork unitOfWork, IMapper mapper)
//        {
//            _unitOfWork = unitOfWork;
//            _mapper = mapper;
//        }

//        public async Task<int> Handle(CreateCategoryCommand request, CancellationToken cancellationToken)
//        {
//            //var validator = new CreateCategoryDtoValidator();
//            //var validatorResult = await validator.ValidateAsync(request.CategoryDto);

//            //if (validatorResult.IsValid == false)
//            //{
//            //    throw new ValidationException(validatorResult);
//            //}
//            //var category = _mapper.Map<Category>(request.CategoryDto);
//            //category = await _unitOfWork.CategoryRepository.Add(category);
//            //await _unitOfWork.Save();

//            //return category.Id;
//            throw new NotImplementedException();

//        }
//    }
//}
