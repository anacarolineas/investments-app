using Ardalis.Result;
using Halle.Investments.Application.Common;
using Halle.Investments.Domain.Entities.Common;
using Halle.Investments.Domain.Entities.Rebalancing;
using Halle.Investments.Domain.Interfaces.Auth;
using Halle.Investments.Domain.Interfaces.Repositories;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Halle.Investments.Application.Features.Rebalancing.CreateRebalancingUser
{
    public sealed class CreateRebalancingUserHandler : IRequestHandler<Result<CreateRebalancingUserRequest>, RebalancingUserId>
    {
        private readonly ISession _session;
        private readonly IApplicationDbContext _context;

        public CreateRebalancingUserHandler(
            ISession session, 
            IApplicationDbContext context)
        {
            _session = session;
            _context = context;
        }

        public async Task<Result<RebalancingUserId>> Handle(CreateRebalancingUserRequest request, CancellationToken cancellationToken)
        {
            var rebalancingParameter = new RebalancingParameter(
                request.ContributionValue, 
                request.ContributionAssets, 
                request.ContributionClasses
                );

            var userId = _session.UserId;

            var rebalancing = new RebalancingUser(userId, rebalancingParameter);

            await _context.RebalancingUsers.AddAsync(rebalancing);

            await _context.SaveChangesAsync(cancellationToken);

            return rebalancing.Id;
        }
    }
}
