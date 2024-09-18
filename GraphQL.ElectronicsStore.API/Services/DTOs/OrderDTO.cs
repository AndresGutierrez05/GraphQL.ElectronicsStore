using System.ComponentModel.DataAnnotations;

namespace GraphQL.ElectronicsStore.API.Services.DTOs
{
    public class OrderDTO
    {
        public int OrderID { get; set; }
        public int CustomerID { get; set; }
        public DateTime OrderDate { get; set; }
        public decimal TotalAmount { get; set; }
        public CustomerDTO? Customer { get; set; }
        public IEnumerable<OrderProductDTO> OrderProducts { get; set; }
    }
}
