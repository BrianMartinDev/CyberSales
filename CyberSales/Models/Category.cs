using System;
using System.ComponentModel.DataAnnotations;

namespace CyberSales.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public int DisplayOrder { get; set; }
        public DateTime GeneratedDateTime { get; set; } = DateTime.Now;
    }
}