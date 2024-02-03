using Halle.Investments.Domain.Entities.Common;
using Microsoft.AspNetCore.Http;
using System.Security.Claims;

namespace Halle.Investments.Application.Auth
{
    public class Session : Domain.Interfaces.Auth.ISession
    {
        public UserId UserId { get; private init; }

        public DateTime Now => DateTime.Now;

        public Session(IHttpContextAccessor httpContextAccessor)
        {
            var user = httpContextAccessor.HttpContext?.User;

            var nameIdentifier = user?.FindFirst(ClaimTypes.NameIdentifier);

            if (nameIdentifier != null)
            {
                UserId = new Guid(nameIdentifier.Value);
            }
        }
    }
}
