using BlazorApp1.Models;


namespace BlazorApp1.WebService
{
    public interface InterfazSaul
    {
        public AuthenticationUserModel Autenticacion(string user, string password);
        bool Cargos(Int64 agenda);
    }
}
