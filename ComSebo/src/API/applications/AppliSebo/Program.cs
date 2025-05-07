
var builder = WebApplication.CreateBuilder();
var app = builder.Build();

app.MapGet("/hello", () => "Hello Sebo");
app.Run();
