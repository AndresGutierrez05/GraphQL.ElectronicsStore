using GraphQL.ElectronicsStore.API.Services.DTOs;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Reflection.Emit;

namespace GraphQL.ElectronicsStore.API.Services.Config
{
    public class OrderProductConfig : IEntityTypeConfiguration<OrderProductDTO>
    {
        public void Configure(EntityTypeBuilder<OrderProductDTO> builder)
        {
            builder.HasKey(op => new { op.OrderID, op.ProductID });
            builder
                .HasOne(op => op.Order)
                .WithMany(o => o.OrderProducts)
                .HasForeignKey(op => op.OrderID);
            builder
                .HasOne(op => op.Product)
                .WithMany(p => p.OrderProducts)
                .HasForeignKey(op => op.ProductID);
        }
    }
}
