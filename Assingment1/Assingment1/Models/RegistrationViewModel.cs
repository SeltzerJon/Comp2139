using System.ComponentModel.DataAnnotations;

namespace Assingment1.Models
{
	public class RegistrationViewModel
	{
		[Required]
		public string Username { get; set; }
		[Required]
		public string Password { get; set; }
		[Required]
		[DataType(DataType.Password)]
		[Compare("Password", ErrorMessage = "The password and confirmation password do not match.")]
		public string ConfirmedPassword { get; set; }
		[Required]
		[EmailAddress]
		public string Email { get; set; }
	}
}
