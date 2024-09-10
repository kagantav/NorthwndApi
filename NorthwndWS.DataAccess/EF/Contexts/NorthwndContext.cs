using Microsoft.EntityFrameworkCore;
using NorthwndWS.DataAccess.EF.Configurations;
using NorthwndWS.Model.Entities;
using System.Reflection;

namespace NorthwndWS.DataAccess.EF.Contexts
{
    public class NorthwndContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"server=.\SQLEXPRESS;database=Northwnd;trusted_connection=true;TrustServerCertificate=true;");
        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Supplier> Suppliers { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //https://www.entityframeworktutorial.net/efcore/fluent-api-in-entity-framework-core.aspx

            //modelBuilder.ApplyConfiguration(new CategoryConfiguration());
            //modelBuilder.ApplyConfiguration(new ProductConfiguration());
            //.......
            //.......

            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetAssembly(typeof(CategoryConfiguration)));


        }
    }
}
