using BaseLib.Model;

namespace NorthwndWS.Model.Entities
{
    public class Product:BaseEntity<int>
    {
        public string ProductName { get; set; }
        public decimal? UnitPrice { get; set; }
        public short? UnitsInStock { get; set; }
        public bool? Discontinued { get; set; }
        public int? CategoryId { get; set; }
        public int? SupplierId { get; set; }

        public Category? Category { get; set; }
        public Supplier? Supplier { get; set; }
    }
}
