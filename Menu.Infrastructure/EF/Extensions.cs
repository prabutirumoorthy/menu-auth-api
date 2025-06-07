using Menu.Application.Services;
using Menu.Domain.Repositories;
using Menu.Infrastructure.EF.Contexts;
using Menu.Infrastructure.EF.Options;
using Menu.Infrastructure.EF.Repositories;
using Menu.Infrastructure.EF.Services;
using Menu.Shared.Options;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Menu.Infrastructure.EF;

internal static class Extensions
{
    public static IServiceCollection AddSQLDB(this IServiceCollection services, IConfiguration configuration)
    {
       // services.AddScoped<ISampleEntityRepository, SampleEntityRepository>();
      //  services.AddScoped<ISampleEntityReadService, SampleEntityReadService>();

        // var options = configuration.GetOptions<DataBaseOptions>("DataBaseConnectionString");
        // services.AddDbContext<ReadDbContext>(ctx =>
        // ctx.UseSqlServer(options.ConnectionString));

        // services.AddDbContext<WriteDbContext>(ctx =>
        //     ctx.UseSqlServer(options.ConnectionString));

        return services;
    }
}
