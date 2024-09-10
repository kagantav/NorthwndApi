using BaseLib.Model;

namespace NorthwndWS.Model.Entities
{
    public class Supplier:BaseEntity<int>
    {
        public Supplier()
        {
            Products = new HashSet<Product>();
        }
        public string CompanyName { get; set; }
        public string? ContactName { get; set; }
        public string? Address { get; set; }
        public string? City { get; set; }
        public string? Country { get; set; }

        public ICollection<Product>? Products { get; set; }
    }
}
