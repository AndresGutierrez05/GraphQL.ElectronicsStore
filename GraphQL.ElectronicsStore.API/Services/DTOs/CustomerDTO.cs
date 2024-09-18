using System.ComponentModel.DataAnnotations;

namespace GraphQL.ElectronicsStore.API.Services.DTOs
{
    public class CustomerDTO
    {
        public int CustomerID { get; set; }
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string Phone { get; set; } = string.Empty;
        public string Address { get; set; } = string.Empty;

        public ICollection<OrderDTO> Orders { get; set; }
    }
}
