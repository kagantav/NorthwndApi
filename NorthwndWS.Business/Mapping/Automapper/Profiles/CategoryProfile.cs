using AutoMapper;
using NorthwndWS.Model.Dtos.CategoryDtos;
using NorthwndWS.Model.Entities;

namespace NorthwndWS.Business.Mapping.Automapper.Profiles
{
    public class CategoryProfile:Profile
    {
        public CategoryProfile()
        {
            CreateMap<Category, CategoryGetDto>()
                .ForMember(dest =>
                                dest.ProductCount,
                            opt =>
                                opt.MapFrom(src => src.Products != null ? src.Products.Count : 0));


            CreateMap<CategoryPostDto, Category>()
                .ForMember(dest => 
                                dest.Picture,
                           opt => 
                                opt.MapFrom(src => Convert.FromBase64String(src.PictureBase64)));

            CreateMap<CategoryPutDto, Category>()
                .ForMember(dest =>
                                dest.Picture,
                           opt =>
                                opt.MapFrom(src => Convert.FromBase64String(src.PictureBase64)));

        }
    }
}
