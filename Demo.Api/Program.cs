var builder = WebApplication.CreateBuilder(args);

// Swagger / OpenAPI services
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Enable Swagger UI for all environments (for this demo)
app.UseSwagger();
app.UseSwaggerUI();

// Map endpoints
app.MapGet("/", () => "Demo.Api is running in AWS via CI/CD!");
app.MapGet("/health", () => Results.Ok(new { status = "Healthy", time = DateTime.UtcNow }));


app.MapGet("/version", () =>
{
    var version = Environment.GetEnvironmentVariable("APP_VERSION") ?? "v1-local";
    return Results.Ok(new { version });
});

app.Run();
