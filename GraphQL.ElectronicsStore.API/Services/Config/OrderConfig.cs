using GraphQL.ElectronicsStore.API.Services.DTOs;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GraphQL.ElectronicsStore.API.Services.Config
{
    public class OrderConfig : IEntityTypeConfiguration<OrderDTO>
    {
        public void Configure(EntityTypeBuilder<OrderDTO> builder)
        {
            builder.HasKey(o => o.OrderID);
            builder.Property(o => o.OrderID).UseIdentityColumn();
            builder.Property(o => o.OrderDate).IsRequired().HasDefaultValue(DateTime.Now);
            builder.Property(o => o.OrderDate).IsRequired();
            builder.HasOne(o => o.Customer)
                .WithMany(c => c.Orders)
                .HasForeignKey(o => o.CustomerID);
        }
    }
}
