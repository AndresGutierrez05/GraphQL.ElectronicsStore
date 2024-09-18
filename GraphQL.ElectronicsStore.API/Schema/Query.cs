using GraphQL.ElectronicsStore.API.Models;
using GraphQL.ElectronicsStore.API.Services;
using Microsoft.EntityFrameworkCore;

namespace GraphQL.ElectronicsStore.API.Schema
{
    public class Query(IDbContextFactory<ElectronicsStoreDbContext> contextFactory)
    {
        private readonly IDbContextFactory<ElectronicsStoreDbContext> _contextFactory = contextFactory;

        public IEnumerable<ProductType> GetProducts()
        {
            List<ProductType> products = [];
            using (var context = _contextFactory.CreateDbContext())
            {
                products.AddRange(context.Products.Select(product => new ProductType
                {
                    Price = product.Price,
                    ProductID = product.ProductID,
                    ProductName = product.ProductName,
                    StockQuantity = product.StockQuantity,
                    ImageUrl = product.ImageUrl,
                    Descripcion = product.Description,
                    Categories = product.ProductCategories.Select(p => new CategoryType 
                    { 
                        CategoryID = p.Category.CategoryID, 
                        CategoryName = p.Category.CategoryName
                    })
                }));
            }
            
            return products;
        }

        public CustomerType GetCustomerById(int CustomerID)
        {
            CustomerType customer = new();
            using (var context = _contextFactory.CreateDbContext())
            {
                var customerDB = context.Customers.FirstOrDefault(c => c.CustomerID == CustomerID);
                if (customerDB != null)
                { 
                    customer = new CustomerType
                    {
                        CustomerID = customerDB.CustomerID,
                        Email = customerDB.Email,
                        FirstName = customerDB.FirstName,
                        LastName = customerDB.LastName,
                    };
                }
            }

            return customer;
        }
    }
}
