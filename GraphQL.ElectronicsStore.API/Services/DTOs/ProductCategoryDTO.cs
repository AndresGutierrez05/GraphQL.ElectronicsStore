using Microsoft.EntityFrameworkCore;

namespace GraphQL.ElectronicsStore.API.Services.DTOs
{
    public class ProductCategoryDTO
    {
        public int ProductID { get; set; }
        public ProductDTO Product { get; set; }
        public int CategoryID { get; set; }
        public CategoryDTO Category { get; set; }
    }
}
