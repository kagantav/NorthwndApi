using AutoMapper;
using NorthwndWS.Model.Dtos.ProductDtos;
using NorthwndWS.Model.Entities;

namespace NorthwndWS.Business.Mapping.Automapper.Profiles
{
    public class ProductProfile:Profile
    {
        public ProductProfile()
        {
            CreateMap<Product, ProductGetDto>();
        }
    }
}
