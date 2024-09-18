using System.ComponentModel.DataAnnotations;

namespace GraphQL.ElectronicsStore.API.Services.DTOs
{
    public class CategoryDTO
    {
        public int CategoryID { get; set; }
        public string CategoryName { get; set; } = string.Empty;
        public ICollection<ProductCategoryDTO> ProductCategories { get; set; }
    }
}
