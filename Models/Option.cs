﻿using System.ComponentModel.DataAnnotations;

namespace BlazorShoes.Models
{
    public class Option
    {
        [Key]
        public int Id { get; set; }

        public int ShoeId { get; set; }

        [Required, StringLength(20)]
        public string Type { get; set; } = String.Empty;

        [Required, StringLength(20)]
        public string Brand { get; set; } = String.Empty;

        [Required, Range(1,20)]
        public decimal Size { get; set; }

        [StringLength(20)]
        public string Style { get; set; } = String.Empty;

        [StringLength(20)]
        public string Colour { get; set; } = String.Empty;

        public int Gender { get; set; }

        // Navigation Properties
        public virtual Shoe? Shoe { get; set; } = null;
    }
}
