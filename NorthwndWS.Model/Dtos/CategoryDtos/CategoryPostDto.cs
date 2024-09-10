using BaseLib.Model;

namespace NorthwndWS.Model.Dtos.CategoryDtos
{
    public class CategoryPostDto:IDto
    {
        public string? CategoryName { get; set; }
        public string? Description { get; set; }
        public string? PictureBase64 { get; set; }
        public string? PhotoPath { get; set; }
    }
}
