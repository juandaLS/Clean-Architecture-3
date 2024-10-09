using Microsoft.Extensions.DependencyInjection;
using NorthWind.Core.Services;
using NorthWind.Entities.Interfaces;

namespace NorthWind.Core;

public static class DependencyContainer
{
    public static IServiceCollection AddServices(this IServiceCollection services)
    {
        services.AddSingleton<IAppLogger, AppLogger>();
        services.AddSingleton<IProductService, ProductService>();
        return services;

    }

}
