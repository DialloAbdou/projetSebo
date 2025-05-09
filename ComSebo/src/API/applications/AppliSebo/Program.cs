
using AppliSebo.Endpoints;

var builder = WebApplication.CreateBuilder();

builder.Services.AddSeboBackService();

var app = builder.Build();

app.MapGroup("categorie/").MapBackSeboEndpoint();
app.Run();
