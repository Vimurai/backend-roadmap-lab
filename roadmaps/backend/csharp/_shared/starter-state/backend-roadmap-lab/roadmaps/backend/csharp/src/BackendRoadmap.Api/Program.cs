using BackendRoadmap.Application.Services;
using BackendRoadmap.Contracts;
using BackendRoadmap.Infrastructure.Repositories;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddScoped<IUserRepository, UserRepository>();
builder.Services.AddScoped<UserService>();

var app = builder.Build();

app.MapGet("/", () => "Backend Roadmap API is running!");

app.MapPost("/register", async (UserService service, string email) =>
{
    await service.RegisterUserAsync(email);
    return Results.Ok("User registered (simulated)");
});

app.Run();
