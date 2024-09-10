using BaseLib.Model;

namespace NorthwndWS.Model.Dtos.CategoryDtos
{
    public class CategoryPutDto:IDto
    {
        public int Id { get; set; }
        public string CategoryName { get; set; }
        public string Description { get; set; }
        public string PictureBase64 { get; set; }
        public string? PhotoPath { get; set; }
    }
}
