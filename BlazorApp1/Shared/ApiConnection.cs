namespace BlazorApp1.Shared
{
	public class ApiConnection
	{

		private string secretKey = string.Empty;
		private string baseUrl = string.Empty;
		public ApiConnection()
		{
			var builder = new ConfigurationBuilder().SetBasePath(Directory.GetCurrentDirectory()).AddJsonFile("appsettings.json").Build();
			secretKey = builder.GetSection("APISettings:secretKey").Value;
			baseUrl = builder.GetSection("APISettings:baseUrl").Value;


		}
		public string get_secretKey()
		{
			return secretKey;
		}

		public string get_baseUrl()
		{
			return baseUrl;
		}
	}
}
