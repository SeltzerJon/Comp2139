using System.ComponentModel.DataAnnotations;

namespace Lab3.Models
{
    public class Category
    {
        [Key]
        public int CategoryId { get; set; }
        public string? Name { get; set; }

    }
}
