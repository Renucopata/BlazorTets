using Refit;
using System.Text.Json.Serialization;

namespace BlazorApp1.Models
{
	public class TokenRequest
	{
		[JsonPropertyName("token")]
		public string Token { get; set; }
	}
}
