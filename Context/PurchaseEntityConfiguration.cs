using FirstMVCApp.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FirstMVCApp.Context
{
    public class PurchaseEntityConfiguration : IEntityTypeConfiguration<Purchase>
    {
        public void Configure(EntityTypeBuilder<Purchase> builder)
        {
            builder.Property(u => u.Person).IsRequired();
            builder.Property(u => u.Address).IsRequired();
        }
    }
}