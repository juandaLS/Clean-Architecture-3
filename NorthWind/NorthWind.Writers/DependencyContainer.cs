using NorthWind.Writers;

namespace Microsoft.Extensions.DependencyInjection;

public static class DependencyContainer
{
    public static IServiceCollection AddConsoleWriter(this IServiceCollection services)
    {
        services.AddSingleton<IUserActionWriter, ConsoleWriter>();
        return services;
    }
    public static IServiceCollection AddDebugWriter(this IServiceCollection services)
    {
        services.AddSingleton<IUserActionWriter, DebugWriter>();
        return services;
    }
    public static IServiceCollection AddFileWriter(this IServiceCollection services)
    {
        services.AddSingleton<IUserActionWriter, FileWriter>();
        return services;
    }
}
