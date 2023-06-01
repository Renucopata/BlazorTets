namespace BlazorApp1.Models
{
	public class ApiResponseModel
	{

		//Change the  JsonPropertyName to the exact headers name

		public string UserName { get; set;}
		public string Password { get; set;}
		public string Email { get; set;}
		public string Nombre { get; set;}
		public string Cargo { get; set;}
		public int IdAgenda { get; set;}
		
	}
}
