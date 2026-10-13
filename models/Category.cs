
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MadyanCommercePJ.models
{
    public class Category
    {
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        public string Name { get; set; } = string.Empty;

        public List<Product> Products { get; set; } = new();
    }
}
