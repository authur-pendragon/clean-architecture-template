using CleanArchitectureTemplate.Domain.Entities;

namespace CleanArchitectureTemplate.Application.Interfaces;

public interface IWeatherForecastRepository
{
    Task<List<WeatherForecast>> GetAsync();
    Task AddAsync(WeatherForecast forecast);
}
