using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using WebApi_ENDE_Crypt.Endpoints;
using WebApi_ENDE_Crypt.Services;

var builder = WebApplication.CreateBuilder(args);

// Register Services for Dependency Injection (DI)
builder.Services.AddSingleton<IKeyService, KeyService>();
builder.Services.AddSingleton<IPasswordService, PasswordService>();
builder.Services.AddSingleton<IEncodingService, EncodingService>();

var app = builder.Build();
app.MapGet("/", () => "Hello Earth 🌎!");

// Map API Endpoints
app.MapKeyEndpoints();
app.MapPasswordEndpoints();
app.MapEncodingEndpoints();

app.Run();

// Ensure Program is accessible for testing
public partial class Program { }