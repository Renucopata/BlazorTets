
using System.ComponentModel.DataAnnotations;


namespace BlazorApp1.Models

{
	public class AuthenticationUserModel
	{
		[Required]
		public string UserName { get; set; }

		[Required]
		public string Password { get; set; }
	}
}
