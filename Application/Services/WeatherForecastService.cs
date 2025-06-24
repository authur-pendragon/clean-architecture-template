using CleanArchitectureTemplate.Application.Interfaces;
using CleanArchitectureTemplate.Domain.Entities;

namespace CleanArchitectureTemplate.Application.Services;

public class WeatherForecastService
{
    private readonly IWeatherForecastRepository _repository;

    public WeatherForecastService(IWeatherForecastRepository repository)
    {
        _repository = repository;
    }

    public Task<List<WeatherForecast>> GetAsync() => _repository.GetAsync();

    public Task AddAsync(WeatherForecast forecast) => _repository.AddAsync(forecast);
}
