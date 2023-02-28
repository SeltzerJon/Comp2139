using System.ComponentModel.DataAnnotations;

namespace Assignment1Final.Models
{
    public class Item
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string MinimumBidAmount { get; set; }
        public DateTime StartBidDate { get; set; }
        public DateTime EndBidDate { get; set; }
        public string Condition { get; set; }
        [Required(ErrorMessage = "Category is required.")]
        public string Category { get; set; }
        [Required(ErrorMessage = "Image is required.")]
        public byte[] Image { get; set; }
        public string SellerUsername { get; set; }
    }
}
