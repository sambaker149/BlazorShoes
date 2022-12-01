using System.ComponentModel.DataAnnotations;

namespace BlazorShoes.Models
{
    public class OrderItem
    {
        [Key]
        public virtual int ShoeId { get; set; }

        [Key]
        public virtual int OrderId { get; set; }

        [Required, Range(15.00,100)]
        public decimal SalePrice { get; set; }

        [Required, Range(1,5)]
        public int Quantity { get; set; }

        // Navigation Properties
        public virtual Shoe Shoe { get; set; }
        public virtual Order Order { get; set; }
    }
}
