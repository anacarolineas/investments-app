using Halle.Investments.Infrastructure.Persistence;
using MassTransit.NewIdProviders;
using MassTransit;
using Halle.Investments.Application.Common;

namespace Halle.Investments.WebApi.Configurations
{
    public static class ApplicationSetup
    {
        public static IServiceCollection AddApplicationSetup(this IServiceCollection services)
        {
            services.AddScoped<IApplicationDbContext, ApplicationDbContext>();
            NewId.SetProcessIdProvider(new CurrentProcessIdProvider());

            return services;
        }
    }
}
