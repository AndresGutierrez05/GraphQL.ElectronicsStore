﻿using System.ComponentModel.DataAnnotations;

namespace GraphQL.ElectronicsStore.API.Services.DTOs
{
    public class ProductDTO
    {
        public int ProductID { get; set; }
        public string ProductName { get; set; } = string.Empty;
        public decimal Price { get; set; }
        public int StockQuantity { get; set; }
        public string ImageUrl { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public ICollection<OrderProductDTO> OrderProducts { get; set; }
        public ICollection<ProductCategoryDTO> ProductCategories { get; set; }
    }
}
