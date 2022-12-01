using System.ComponentModel.DataAnnotations;

namespace BlazorShoes.Models
{
    public class Order
    {
        [Key]
        public int OrderId { get; set; }

        [Required, DataType(DataType.Date)]
        public DateTime PlannedDelivery { get; set; }

        [DataType(DataType.Date)]
        public DateTime ActualDelivery { get; set; }

        [StringLength(20)]
        public string OrderStatus { get; set; } = String.Empty;

        // Navigation Properties
        public virtual ICollection<Customer> CustomerDetails { get; set; }
    }
}
