using Menu.Infrastructure.EF;
using Menu.Infrastructure.Logging;
using Menu.Infrastructure.Services;
using Menu.Shared.Abstractions.Commands;
using Menu.Shared.Queries;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Menu.Infrastructure;

public static class Extensions
{
    public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddSQLDB(configuration);
        services.AddQueries();
        services.AddSerilog(configuration);
        //services.AddSingleton<IExternalService, ExternalService>();
        services.TryDecorate(typeof(ICommandHandler<>), typeof(LoggingCommandHandlerDecorator<>));

        return services;
    }
}
