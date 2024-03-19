//using FluentValidation;
//using StoreProject.Application.Contracts.IReposiotry;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace StoreProject.Application.DTOs.Product.Validators
//{
//    public class UpdateProductDtoValidator : AbstractValidator<UpdateProductDto>
//    {
//        private readonly IBrandRepository _brandRepository;
//        private readonly ICategoryRepository _categoryRepository;

//        public UpdateProductDtoValidator(IBrandRepository brandRepository, ICategoryRepository categoryRepository)
//        {
//            _brandRepository = brandRepository;
//            _categoryRepository = categoryRepository;
//            RuleFor(p => p.Name)
//                .NotEmpty().WithMessage("{PropertyName} is required");

//            RuleFor(p => p.Description)
//                   .NotEmpty().WithMessage("{PropertyName} is required");
//            RuleFor(p => p.CategoryId)
//             .NotNull().WithMessage("{PropertyName} is required")
//             .MustAsync(async (id, token) =>
//             {
//                 var exists = await _categoryRepository.Exists(id);
//                 return exists;
//             }).WithMessage("{PropertyName} does not exist.");

//            RuleFor(p => p.BrandId)
//                 .MustAsync(async (id, token) => {
//                     var exists = await _brandRepository.Exists(id);
//                     return exists;
//                 })
//                .NotNull().WithMessage("{PropertyName} is required");

//            RuleFor(p => p.ImageUrl)
//             .NotNull().WithMessage("{PropertyName} is required");
//        }
//    }
//}
