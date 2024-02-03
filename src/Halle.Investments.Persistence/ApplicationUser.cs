using Halle.Investments.Domain.Interfaces;
using MassTransit;
using Microsoft.AspNetCore.Identity;

namespace Halle.Investments.Infraestructure
{
    public class ApplicationUser : IdentityUser<Guid>, IUser
    {
        public override Guid Id { get; set; } = NewId.NextSequentialGuid();
    }

    public class ApplicationRole : IdentityRole<Guid> 
    {
        public override Guid Id { get; set; } = NewId.NextSequentialGuid();
    }
}
