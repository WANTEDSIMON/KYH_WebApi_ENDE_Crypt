using Microsoft.AspNetCore.Builder;
using WebApi_ENDE_Crypt.Services;

namespace WebApi_ENDE_Crypt.Endpoints;

public static class KeyEndpoints
{
    public static void MapKeyEndpoints(this WebApplication app)
    {
        app.MapGet("/key", (IKeyService keyService) => keyService.GenerateRandomKey());
    }
}