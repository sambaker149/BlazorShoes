using System.ComponentModel.DataAnnotations;

namespace BlazorShoes.Models
{
    public class Payment
    {
        [Key]
        public int PaymentId { get; set; }

        [Required, MaxLength(16)]
        public long CardNumber { get; set; }

        [Required, MaxLength(2)]
        public int ExpiryMonth { get; set; }

        [Required, MaxLength(4)]
        public int ExpiryYear { get; set; }

        [Required, MaxLength(3)]
        public int CVVNumber { get; set; }
    }
}
