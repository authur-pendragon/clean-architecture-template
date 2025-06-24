using CleanArchitectureTemplate.Application.Interfaces;
using CleanArchitectureTemplate.Infrastructure.Context;
using CleanArchitectureTemplate.Infrastructure.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace CleanArchitectureTemplate.Infrastructure;

public static class ServiceCollectionExtensions
{
    public static IServiceCollection AddInfrastructure(this IServiceCollection services, string connectionString)
    {
        services.AddDbContext<WeatherForecastDbContext>(options =>
            options.UseSqlServer(connectionString));
        services.AddScoped<IWeatherForecastRepository, WeatherForecastRepository>();
        return services;
    }
}
