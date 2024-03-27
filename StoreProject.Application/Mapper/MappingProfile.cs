using AutoMapper;
using StoreProject.Application.Categories.Commands.Create;
using StoreProject.Application.Categories.Commands.Update;
using StoreProject.Domain.Entities;


namespace StoreProject.Application.Profiles
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<CreateCategoryCommand, Category>().ReverseMap();
            CreateMap<UpdateCategoryCommand, Category>().ReverseMap();

        }
    }
}
