using System.ComponentModel.DataAnnotations;

namespace database.Models
{
    public class Contact
    {
        [Key]
        public int ContactId { get; set; }
        [Required(ErrorMessage = "Please enter a valid first name")]
        public string? FirstName { get; set; }
        [Required(ErrorMessage = "Please enter a valid last name")]
        public string? LastName { get; set; }
        [Required(ErrorMessage = "Please enter a valid phone")]
        public string? Phone { get; set; }
        [Required(ErrorMessage = "Please enter a valid email")]
        public string? Email { get; set; }

        public string? Organiztion { get; set; }
        public DateTime DateAdded { get; set; }
        [Range(1, 4, ErrorMessage = "Please enter a valid category")]
        public int CategoryId { get; set; }

        public Category? Category { get; set; }

        public String Slug => FirstName?.Replace(" ", "-").ToLower() + "-" + LastName?.Replace(" ", "-").ToLower();
    }
}
