namespace GraphQL.ElectronicsStore.API.Models
{
    public class ProductType
    {
        public int ProductID { get; set; }
        public string ProductName { get; set; } = string.Empty;
        public decimal Price { get; set; }
        public int StockQuantity { get; set; }
        public string Descripcion { get; set; } = string.Empty;
        public string ImageUrl { get; set; } = string.Empty;
        public required IEnumerable<CategoryType> Categories { get; set; }
    }
}
