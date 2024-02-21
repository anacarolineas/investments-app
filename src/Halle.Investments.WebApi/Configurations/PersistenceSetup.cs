using EntityFramework.Exceptions.PostgreSQL;
using Halle.Investments.Application.Auth;
using Halle.Investments.Infrastructure;
using Halle.Investments.Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;

namespace Halle.Investments.WebApi.Configurations
{
    public static class PersistenceSetup
    {
        public static IServiceCollection AddPersistenceSetup(this IServiceCollection services, IConfiguration configuration) 
        {
            services.AddScoped<Domain.Interfaces.Auth.ISession, Session>();

            services.AddHostedService<ApplicationDbInitializer>();
            services.AddDbContextPool<ApplicationDbContext>(o =>
            {
                o.UseNpgsql(configuration.GetConnectionString("DefaultConnection"));
                o.UseExceptionProcessor();
            });

            return services;
        }
    }
}
