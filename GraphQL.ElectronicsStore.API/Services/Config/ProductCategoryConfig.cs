using GraphQL.ElectronicsStore.API.Services.DTOs;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Reflection.Emit;

namespace GraphQL.ElectronicsStore.API.Services.Config
{
    public class ProductCategoryConfig : IEntityTypeConfiguration<ProductCategoryDTO>
    {
        public void Configure(EntityTypeBuilder<ProductCategoryDTO> builder)
        {
            builder.HasKey(pc => new { pc.ProductID, pc.CategoryID });
            builder
                .HasOne(pc => pc.Product)
                .WithMany(p => p.ProductCategories)
                .HasForeignKey(pc => pc.ProductID);
            builder
                .HasOne(pc => pc.Category)
                .WithMany(c => c.ProductCategories)
                .HasForeignKey(pc => pc.CategoryID);
            builder.HasData(new List<ProductCategoryDTO>()
            {
                new() { ProductID = 1, CategoryID = 1 },
                new() { ProductID = 1, CategoryID = 2 },
                new() { ProductID = 2, CategoryID = 1 },
                new() { ProductID = 2, CategoryID = 3 },
                new() { ProductID = 3, CategoryID = 1 },
                new() { ProductID = 3, CategoryID = 4 },
                new() { ProductID = 4, CategoryID = 1 },
                new() { ProductID = 4, CategoryID = 5 },
                new() { ProductID = 5, CategoryID = 1 },
                new() { ProductID = 5, CategoryID = 6 },
                new() { ProductID = 5, CategoryID = 26 },
                new() { ProductID = 6, CategoryID = 7 },
                new() { ProductID = 6, CategoryID = 8 },
                new() { ProductID = 7, CategoryID = 7 },
                new() { ProductID = 7, CategoryID = 9 },
                new() { ProductID = 8, CategoryID = 7 },
                new() { ProductID = 8, CategoryID = 10 },
                new() { ProductID = 9, CategoryID = 7 },
                new() { ProductID = 9, CategoryID = 11 },
                new() { ProductID = 10, CategoryID = 7 },
                new() { ProductID = 10, CategoryID = 12 },
                new() { ProductID = 11, CategoryID = 7 },
                new() { ProductID = 11, CategoryID = 13 },
                new() { ProductID = 12, CategoryID = 7 },
                new() { ProductID = 12, CategoryID = 14 },
                new() { ProductID = 13, CategoryID = 7 },
                new() { ProductID = 13, CategoryID = 15 },
                new() { ProductID = 14, CategoryID = 16 },
                new() { ProductID = 14, CategoryID = 17 },
                new() { ProductID = 15, CategoryID = 16 },
                new() { ProductID = 15, CategoryID = 18 },
                new() { ProductID = 16, CategoryID = 19 },
                new() { ProductID = 16, CategoryID = 22 },
                new() { ProductID = 17, CategoryID = 20 },
                new() { ProductID = 18, CategoryID = 21 },
                new() { ProductID = 19, CategoryID = 22 },
                new() { ProductID = 19, CategoryID = 24 },
                new() { ProductID = 20, CategoryID = 1 },
                new() { ProductID = 20, CategoryID = 25 },
                new() { ProductID = 21, CategoryID = 26 },
                new() { ProductID = 21, CategoryID = 27 },
                new() { ProductID = 22, CategoryID = 26 },
                new() { ProductID = 22, CategoryID = 27 },
                new() { ProductID = 23, CategoryID = 1 },
                new() { ProductID = 23, CategoryID = 26 },
                new() { ProductID = 24, CategoryID = 1 },
                new() { ProductID = 24, CategoryID = 26 },
                new() { ProductID = 25, CategoryID = 1 },
                new() { ProductID = 25, CategoryID = 30 },
                new() { ProductID = 26, CategoryID = 1 },
                new() { ProductID = 26, CategoryID = 31 },
                new() { ProductID = 27, CategoryID = 1 },
                new() { ProductID = 27, CategoryID = 30 },
                new() { ProductID = 28, CategoryID = 30 },
                new() { ProductID = 29, CategoryID = 7 },
                new() { ProductID = 29, CategoryID = 13 },
                new() { ProductID = 30, CategoryID = 1 },
                new() { ProductID = 30, CategoryID = 32 },
                new() { ProductID = 31, CategoryID = 1 },
                new() { ProductID = 31, CategoryID = 32 },
                new() { ProductID = 32, CategoryID = 1 },
                new() { ProductID = 32, CategoryID = 32 },
                new() { ProductID = 33, CategoryID = 1 },
                new() { ProductID = 33, CategoryID = 33 },
                new() { ProductID = 34, CategoryID = 26 },
                new() { ProductID = 34, CategoryID = 33 },
                new() { ProductID = 35, CategoryID = 1 },
                new() { ProductID = 36, CategoryID = 1 },
                new() { ProductID = 36, CategoryID = 28 },
                new() { ProductID = 37, CategoryID = 29 },
                new() { ProductID = 38, CategoryID = 29 },
                new() { ProductID = 39, CategoryID = 1 },
                new() { ProductID = 39, CategoryID = 28 }
            });
        }
    }
}
