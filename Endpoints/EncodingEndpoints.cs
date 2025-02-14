using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using WebApi_ENDE_Crypt.Services;

namespace WebApi_ENDE_Crypt.Endpoints;

public static class EncodingEndpoints
{
    public static void MapEncodingEndpoints(this WebApplication app)
    {
        app.MapGet("/encode", (HttpContext context, IEncodingService encodingService) =>
        {
            if (!context.Request.Query.TryGetValue("text", out var text) ||
                !context.Request.Query.TryGetValue("key", out var key))
            {
                return Results.BadRequest("Missing 'text' or 'key' parameter.");
            }

            return Results.Text($"Encoded: {encodingService.Encode(text, key)}");
        });

        app.MapGet("/decode", (HttpContext context, IEncodingService encodingService) =>
        {
            if (!context.Request.Query.TryGetValue("text", out var encodedText) ||
                !context.Request.Query.TryGetValue("key", out var key))
            {
                return Results.BadRequest("Missing 'text' or 'key' parameter.");
            }

            return Results.Text($"Decoded: {encodingService.Decode(encodedText, key)}");
        });
    }
}