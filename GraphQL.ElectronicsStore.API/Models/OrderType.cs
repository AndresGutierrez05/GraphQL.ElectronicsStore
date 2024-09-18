namespace GraphQL.ElectronicsStore.API.Models
{
    public class OrderType
    {
        [GraphQLIgnore]
        public int OrderID { get; set; }

        public int CustomerID { get; set; }

        [GraphQLIgnore]
        public DateTime OrderDate { get; set; }

        public decimal TotalAmount { get; set; }
        public IEnumerable<OrderProductType> OrderProducts { get; set; }
    }
}
