using Halle.Investments.Application;

namespace Halle.Investments.WebApi.Configurations
{
    public static class MediatRSetup
    {
        public static IServiceCollection AddMediatRSetup(this IServiceCollection services)
        {
            services.AddMediatR((config =>
            {
                config.RegisterServicesFromAssemblyContaining(typeof(IAssemblyMarker));
                
                //config.AddOpenBehavior(typeof(ValidationResultPipelineBehavior<,>));
            }));

            return services;
        }
    }
}
