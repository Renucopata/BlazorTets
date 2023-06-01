using System.Text.Json.Serialization;

namespace BlazorApp1.Models
{
	public class ApiResponseModel
	{

		//Change the  JsonPropertyName to the exact headers name

		[JsonPropertyName("login")]
		public string UserName { get; set;}

		[JsonPropertyName("email")]
		public string Email { get; set;}
	

		[JsonPropertyName("cargo")]
		public string Cargo { get; set;}

		[JsonPropertyName("codigo_agenda")]
		public int IdAgenda { get; set;}
		
	}
}
