var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "Demo.Api is running!");

app.MapGet("/version", () =>
{
    var version = Environment.GetEnvironmentVariable("APP_VERSION") ?? "v1-local";
    return Results.Ok(new { version });
});

app.Run();
