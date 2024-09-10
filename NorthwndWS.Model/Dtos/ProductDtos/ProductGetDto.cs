using BaseLib.Model;

namespace NorthwndWS.Model.Dtos.ProductDtos
{
    public class ProductGetDto : IDto
    {
        public string ProductName { get; set; }
        public decimal? UnitPrice { get; set; }
        public short? UnitsInStock { get; set; }
    }
}
