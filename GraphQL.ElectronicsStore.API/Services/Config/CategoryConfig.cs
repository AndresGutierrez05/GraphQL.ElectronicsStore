using GraphQL.ElectronicsStore.API.Services.DTOs;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GraphQL.ElectronicsStore.API.Services.Config
{
    public class CategoryConfig : IEntityTypeConfiguration<CategoryDTO>
    {
    public void Configure(EntityTypeBuilder<CategoryDTO> builder)
        {
            builder.HasKey(p => p.CategoryID);
            builder.Property(x => x.CategoryID).UseIdentityColumn();
            builder.Property(x => x.CategoryName).IsRequired().HasMaxLength(50);
            builder.HasData(new List<CategoryDTO>()
            {
                new() { CategoryID = 1, CategoryName = "Home Entertainment" },
                new() { CategoryID = 2, CategoryName = "Televisions" },
                new() { CategoryID = 3, CategoryName = "Home Theater Systems" },
                new() { CategoryID = 4, CategoryName = "DVD/Blu-ray Players" },
                new() { CategoryID = 5, CategoryName = "Streaming Devices" },
                new() { CategoryID = 6, CategoryName = "Soundbars and Speakers" },
                new() { CategoryID = 7, CategoryName = "Computers and Accessories" },
                new() { CategoryID = 8, CategoryName = "Laptops" },
                new() { CategoryID = 9, CategoryName = "Desktop PCs" },
                new() { CategoryID = 10, CategoryName = "Monitors" },
                new() { CategoryID = 11, CategoryName = "Printers and Scanners" },
                new() { CategoryID = 12, CategoryName = "Keyboards, Mice, and Trackpads" },
                new() { CategoryID = 13, CategoryName = "External Hard Drives and SSDs" },
                new() { CategoryID = 14, CategoryName = "USB Flash Drives" },
                new() { CategoryID = 15, CategoryName = "Routers and Modems" },
                new() { CategoryID = 16, CategoryName = "Mobile Devices" },
                new() { CategoryID = 17, CategoryName = "Smartphones" },
                new() { CategoryID = 18, CategoryName = "Tablets" },
                new() { CategoryID = 19, CategoryName = "Smartwatches" },
                new() { CategoryID = 20, CategoryName = "E-Readers" },
                new() { CategoryID = 21, CategoryName = "Mobile Accessories" },
                new() { CategoryID = 22, CategoryName = "Wearables and Fitness Gadgets" },
                new() { CategoryID = 23, CategoryName = "Smartwatches" },
                new() { CategoryID = 24, CategoryName = "Fitness Trackers" },
                new() { CategoryID = 25, CategoryName = "Virtual Reality Headsets" },
                new() { CategoryID = 26, CategoryName = "Audio Equipment" },
                new() { CategoryID = 27, CategoryName = "Headphones" },
                new() { CategoryID = 28, CategoryName = "Kitchen Room" },
                new() { CategoryID = 29, CategoryName = "Laundry Room" },
                new() { CategoryID = 30, CategoryName = "Photography" },
                new() { CategoryID = 31, CategoryName = "Video Camera" },
                new() { CategoryID = 32, CategoryName = "Gaming Consoles" },
                new() { CategoryID = 33, CategoryName = "Gaming Accessories" }
            });
        }
    }
}
