namespace Mango.Web.Service.IService
{
    public interface ITockenProvider
    {
        void SetToken(string token);
        string? GetToken();
        void ClearToken();
    }
}
