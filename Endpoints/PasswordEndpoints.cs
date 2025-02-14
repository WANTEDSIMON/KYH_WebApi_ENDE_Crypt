using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using WebApi_ENDE_Crypt.Services;

namespace WebApi_ENDE_Crypt.Endpoints;

public static class PasswordEndpoints
{
    public static void MapPasswordEndpoints(this WebApplication app)
    {
        app.MapGet("/password", (HttpContext context, IPasswordService passwordService) =>
        {
            int length = PasswordGenerator.GetPasswordLength(context);
            return Results.Text($"Generated Password: {passwordService.GenerateSecurePassword(length)}");
        });
    }
}