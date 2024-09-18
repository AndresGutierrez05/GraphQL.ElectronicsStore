using GraphQL.ElectronicsStore.API.Services.Config;
using GraphQL.ElectronicsStore.API.Services.DTOs;
using Microsoft.EntityFrameworkCore;

namespace GraphQL.ElectronicsStore.API.Services
{
    public partial class ElectronicsStoreDbContext : DbContext
    {
        public ElectronicsStoreDbContext(DbContextOptions<ElectronicsStoreDbContext> options) 
            : base(options) 
        {
        }

        public virtual DbSet<CategoryDTO> Categories { get; set; }
        public virtual DbSet<CustomerDTO> Customers { get; set; }
        public virtual DbSet<OrderDTO> Orders { get; set; }
        public virtual DbSet<ProductDTO> Products { get; set; }
        public virtual DbSet<ProductCategoryDTO> ProductCategories { get; set; }
        public virtual DbSet<OrderProductDTO> OrderProducts { get; set; }
        
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasDefaultSchema("ElectronicsStore");
            modelBuilder.ApplyConfiguration(new CategoryConfig());
            modelBuilder.ApplyConfiguration(new CustomerConfig());
            modelBuilder.ApplyConfiguration(new OrderConfig());
            modelBuilder.ApplyConfiguration(new OrderProductConfig());
            modelBuilder.ApplyConfiguration(new ProductCategoryConfig());
            modelBuilder.ApplyConfiguration(new ProductConfig());
        }
    }
}
