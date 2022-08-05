using Microsoft.Extensions.DependencyInjection;
using NeerCore.DependencyInjection.Extensions;
using NeerCore.Mapping.Extensions;

namespace JuniorTemplate.Application;

public static class DependencyInjection
{
    public static void AddApplication(this IServiceCollection services)
    {
        services.ConfigureAllOptions();
        services.RegisterAllMappers();
    }
}