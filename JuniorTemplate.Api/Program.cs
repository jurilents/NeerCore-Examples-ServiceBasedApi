using JuniorTemplate.Application;
using JuniorTemplate.Data;
using JuniorTemplate.Infrastructure;
using NeerCore.Api;
using NeerCore.Api.Extensions;
using NeerCore.Api.Extensions.Swagger;
using NeerCore.Logging;
using NeerCore.Logging.Extensions;
using NLog;

var logger = LoggerInstaller.InitFromCurrentEnvironment();

try
{
    var builder = WebApplication.CreateBuilder(args);
    ConfigureBuilder(builder);

    var app = builder.Build();
    ConfigureWebApp(app);

    app.Run();
}
catch (Exception e)
{
    logger.Fatal(e);
}
finally
{
    logger.Info("Application is now stopping");
    LogManager.Shutdown();
}

// ==========================================

static void ConfigureBuilder(WebApplicationBuilder builder)
{
    builder.Logging.ConfigureNLogAsDefault();

    builder.Services.AddSqlServerDatabase();
    builder.Services.AddApplication(builder.Configuration);
    builder.Services.AddInfrastructure();

    builder.Services.AddNeerApiServices();
    builder.Services.AddNeerControllers();
}

static void ConfigureWebApp(WebApplication app)
{
    if (app.Configuration.GetSwaggerSettings().Enabled)
        app.UseCustomSwagger();

    app.UseCors(CorsPolicies.AcceptAll);
    app.UseHttpsRedirection();

    app.UseCustomExceptionHandler();

    app.MapControllers();
}