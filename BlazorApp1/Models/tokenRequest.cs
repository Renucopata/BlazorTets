using Refit;
using System.Text.Json.Serialization;

namespace BlazorApp1.Models
{
	public class tokenRequest
	{
		[JsonPropertyName("token")]
		public string Token { get; set; }
	}
}
