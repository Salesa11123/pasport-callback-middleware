var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();

var app = builder.Build();

app.MapControllers();

app.MapGet("/", () => Results.Ok(new
{
    service = "PaSPort Callback Middleware",
    status = "running",
    callbackEndpoint = "/api/si-workorders-callback"
}));

app.Run();
