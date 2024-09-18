using GraphQL.ElectronicsStore.API.Services.DTOs;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GraphQL.ElectronicsStore.API.Services.Config
{
    public class CustomerConfig : IEntityTypeConfiguration<CustomerDTO>
    {
        public void Configure(EntityTypeBuilder<CustomerDTO> builder)
        {
            builder.HasKey(x => x.CustomerID);
            builder.Property(x => x.CustomerID).UseIdentityColumn();
            builder.Property(x => x.FirstName).IsRequired().HasMaxLength(50);
            builder.Property(x => x.LastName).IsRequired().HasMaxLength(50);
            builder.Property(x => x.Email).IsRequired().HasMaxLength(100);
            builder.Property(x => x.Phone).IsRequired().HasMaxLength(20);
            builder.Property(x => x.Address).IsRequired().HasMaxLength(255);
            builder.HasData(new List<CustomerDTO>()
            {
                new() {
                    CustomerID = 1,
                    FirstName = "Alberto",
                    LastName = "Smith",
                    Email = "AlbertoSmith1785@gmail.com",
                    Address = "1234 Coral Way, Miami, FL 33145",
                    Phone = "+57 3126555555",
                }
            });
        }
    }
}
