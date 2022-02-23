using CineGhost.Api.Services;

namespace CineGhost.Domain.Interfaces;

public interface ICatalog
{
    public async Task<String>  GetCatalog()
    {
        var httpClient = new HttpClient();
        var result = await httpClient.GetStringAsync("");
        return result;
    }
}