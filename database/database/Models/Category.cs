using System.ComponentModel.DataAnnotations;

namespace database.Models
{
    public class Category
    {
        [Key]
        public int CategoryId { get; set; }
        public string? Name { get; set; }
    }
}
