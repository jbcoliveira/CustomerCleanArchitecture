using CustomerCleanArchitecture.Application;
using CustomerCleanArchitecture.Application.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace CustomerCleanArchitecture.Infrastructure;

public static class RegisterService
{
    public static void ConfigureInfraStructure(this IServiceCollection services,
    IConfiguration configuration)
    {
        services.AddDbContext<ApplicationDbContext>(options =>
                options.UseSqlite(configuration.GetConnectionString("CustomerConnection")));

        services.AddScoped<IApplicationDbContext>(option =>
        {
            return option.GetService<ApplicationDbContext>();
        });
    }
}