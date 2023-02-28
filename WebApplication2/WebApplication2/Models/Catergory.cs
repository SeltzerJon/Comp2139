using System.ComponentModel.DataAnnotations;

namespace WebApplication2.Models
{
    public class Catergory
    {
        [Key]
        public int CatergoryId { get; set; }
        public string Name { get;set; }


    }
}
