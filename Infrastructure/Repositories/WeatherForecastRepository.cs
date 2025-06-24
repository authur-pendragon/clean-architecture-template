using CleanArchitectureTemplate.Application.Interfaces;
using CleanArchitectureTemplate.Domain.Entities;
using CleanArchitectureTemplate.Infrastructure.Context;
using Microsoft.EntityFrameworkCore;

namespace CleanArchitectureTemplate.Infrastructure.Repositories;

public class WeatherForecastRepository : IWeatherForecastRepository
{
    private readonly WeatherForecastDbContext _context;

    public WeatherForecastRepository(WeatherForecastDbContext context)
    {
        _context = context;
    }

    public Task<List<WeatherForecast>> GetAsync()
    {
        return _context.WeatherForecasts.AsNoTracking().ToListAsync();
    }

    public async Task AddAsync(WeatherForecast forecast)
    {
        _context.WeatherForecasts.Add(forecast);
        await _context.SaveChangesAsync();
    }
}
