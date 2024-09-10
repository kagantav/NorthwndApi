using BaseLib.Model;
using NorthwndWS.Model.Dtos.ProductDtos;

namespace NorthwndWS.Model.Dtos.CategoryDtos
{
    public class CategoryGetDto:IDto
    {
        public int Id { get; set; }
        public string CategoryName { get; set; }
        public string? Description { get; set; }
        public int ProductCount { get; set; }

        public List<ProductGetDto> Products { get; set; }

        public string Base64Picture { get; set; }
        public string PhotoPath { get; set; }
    }
}
