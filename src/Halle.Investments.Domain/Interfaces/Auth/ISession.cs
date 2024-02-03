using Halle.Investments.Domain.Entities.Common;

namespace Halle.Investments.Domain.Interfaces.Auth
{
    public interface ISession
    {
        public UserId UserId { get; }

        public DateTime Now { get; }
    }
}
