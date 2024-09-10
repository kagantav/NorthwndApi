using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NorthwndWS.Model.Entities;

namespace NorthwndWS.DataAccess.EF.Configurations
{
    public class CategoryConfiguration : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.ToTable("Categories");
            builder.HasKey("Id");

            builder
                        .Property(x => x.CategoryName)
                        .IsRequired()
                        .HasColumnName("CategoryName")
                        .HasColumnType("nvarchar")
            .HasMaxLength(15);

            builder
                        .Property(x => x.Description)
                        .HasColumnName("Description")
                        .HasColumnType("nvarchar");
        }
    }
}
