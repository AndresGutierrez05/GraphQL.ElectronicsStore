using GraphQL.ElectronicsStore.API.Services;
using Microsoft.EntityFrameworkCore;
using GraphQL.ElectronicsStore.API.Models;

namespace GraphQL.ElectronicsStore.API.Schema
{
    public class Mutation(IDbContextFactory<ElectronicsStoreDbContext> contextFactory)
    {
        private readonly IDbContextFactory<ElectronicsStoreDbContext> _contextFactory = contextFactory;
        public bool CreateOrder(OrderType OrderInfo)
        {
            try
            {
                using var context = _contextFactory.CreateDbContext();
                var newOrder = new Services.DTOs.OrderDTO
                {
                    CustomerID = OrderInfo.CustomerID,
                    TotalAmount = OrderInfo.TotalAmount,
                    OrderDate = DateTime.Now,
                };
                context.Orders.Add(newOrder);
                context.SaveChanges();

                context.OrderProducts.AddRange(OrderInfo.OrderProducts.Select(product => new Services.DTOs.OrderProductDTO
                { 
                    OrderID = newOrder.OrderID,
                    ProductID = product.ProductID,
                    Quantity = product.Quantity,
                }));
                context.SaveChanges();
                return true;
            }
            catch (Exception)
            { 
                return false;
            }
        }
    }
}
