
using System;
using System.ComponentModel.DataAnnotations;

namespace MadyanCommercePJ.models
{
    public class Product
    {
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        public string Name { get; set; } = string.Empty;

        [StringLength(500)]
        public string? Description { get; set; }

        public decimal Price { get; set; }

        public int StockQuantity { get; set; }

        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    }
}
