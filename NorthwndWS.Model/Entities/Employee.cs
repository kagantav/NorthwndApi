using BaseLib.Model;
using System.ComponentModel.DataAnnotations.Schema;

namespace NorthwndWS.Model.Entities
{
    public class Employee:BaseEntity<int>
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string? Title { get; set; }
        public string? City { get; set; }
        public string? Country { get; set; }
        public DateTime? BirthDate { get; set; }
        public DateTime? HireDate { get; set; }
        public byte[]? Photo { get; set; }
        public string? PhotoPath { get; set; }
        public string? UserName { get; set; }
        public string? Password { get; set; }

        [ForeignKey("Manager")]
        public int? ReportsTo { get; set; }

        [NotMapped]
        public string FullName
        {
            get
            {
                return $"{FirstName} {LastName}";
            }
        }


        public Employee? Manager { get; set; }
        public ICollection<Employee>? SubEmployees { get; set; }
    }
}
