using NorthWind.Core;

namespace Microsoft.Extensions.DependencyInjection;

public static class DependencyContainer
{
    public static IServiceCollection AddNorthWindServices(this IServiceCollection services)
    {
        services.AddDebugWriter();
        services.AddServices();
        return services;

    }

}
