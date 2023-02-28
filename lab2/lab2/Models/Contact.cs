using lab2.Models;
using System.ComponentModel.DataAnnotations;

namespace Lab2.Models
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
        [Required(ErrorMessage = "Please enter a valid catergort")]
        public int CategoryId { get; set; }

        public Category? Category { get; set; }
    }
}
