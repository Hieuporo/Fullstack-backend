using AutoMapper;
using StoreProject.Application.Categories.Commands.Create;
using StoreProject.Application.Categories.Commands.Update;
using StoreProject.Application.DTOs.Category;
using StoreProject.Application.DTOs.ShippingMethod;
using StoreProject.Application.ShippingMethods.Command.Create;
using StoreProject.Application.ShippingMethods.Command.Update;
using StoreProject.Domain.Entities;


namespace StoreProject.Application.Profiles
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<CreateCategoryCommand, Category>().ReverseMap();
            CreateMap<UpdateCategoryCommand, Category>().ReverseMap();
            CreateMap<CategoryDto, Category>().ReverseMap();

            CreateMap<CreateShippingMethodCommand, ShippingMethod>().ReverseMap();
            CreateMap<UpdateShippingMethodCommand, ShippingMethod>().ReverseMap();
            CreateMap<ShippingMethodDto, ShippingMethod>().ReverseMap();

            CreateMap<CreateShippingMethodCommand, ShippingMethod>().ReverseMap();
            CreateMap<UpdateShippingMethodCommand, ShippingMethod>().ReverseMap();
            CreateMap<ShippingMethodDto, ShippingMethod>().ReverseMap();
        }
    }
}
