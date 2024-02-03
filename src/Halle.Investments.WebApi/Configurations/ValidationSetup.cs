using FluentValidation;
using Halle.Investments.Application;

namespace Halle.Investments.WebApi.Configurations
{
    public static class ValidationSetup
    {
        public static void AddValidationSetup(this WebApplicationBuilder builder)
        {
            builder.Services.AddValidatorsFromAssemblyContaining<IAssemblyMarker>();
        }
    }
}
