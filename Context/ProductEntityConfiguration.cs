using FirstMVCApp.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FirstMVCApp.Context
{
    public class ProductEntityConfiguration : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.Property(u => u.Name).IsRequired();
            builder.Property(u => u.ImagePath).IsRequired();
        }
    }
}