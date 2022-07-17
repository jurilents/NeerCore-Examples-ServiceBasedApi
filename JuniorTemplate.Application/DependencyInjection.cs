using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using NeerCore.Mapping.Extensions;

namespace JuniorTemplate.Application;

public static class DependencyInjection
{
    public static void AddApplication(this IServiceCollection services, IConfiguration configuration)
    {
        services.BindConfigurationOptions(configuration);
        services.RegisterMappersFromCurrentAssembly();
    }


    private static void BindConfigurationOptions(this IServiceCollection services, IConfiguration configuration)
    {
        // services.Configure<SmtpOptions>(configuration.GetSection("Smtp"));
    }
}