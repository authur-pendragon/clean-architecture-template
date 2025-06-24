using CleanArchitectureTemplate.Application.Services;
using CleanArchitectureTemplate.Domain.Entities;
using CleanArchitectureTemplate.Infrastructure;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var connectionString = builder.Configuration.GetConnectionString("Default") ?? throw new InvalidOperationException("Connection string not found.");
builder.Services.AddInfrastructure(connectionString);
builder.Services.AddScoped<WeatherForecastService>();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.MapGet("/weatherforecast", async (WeatherForecastService service) =>
{
    return await service.GetAsync();
})
.WithName("GetWeatherForecast");

app.MapPost("/weatherforecast", async (WeatherForecast forecast, WeatherForecastService service) =>
{
    await service.AddAsync(forecast);
    return Results.Created($"/weatherforecast/{forecast.Id}", forecast);
})
.WithName("CreateWeatherForecast");

app.Run();
