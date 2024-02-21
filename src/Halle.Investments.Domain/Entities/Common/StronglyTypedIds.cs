using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Halle.Investments.Domain.Entities.Common;

public interface IGuid { }

[StronglyTypedId]
public partial struct RebalancingParameterId : IGuid
{
    public static implicit operator RebalancingParameterId(Guid guid)
    {
        return new RebalancingParameterId(guid);
    }
}

[StronglyTypedId]
public partial struct UserId : IGuid
{
    public static implicit operator UserId(Guid guid)
    {
        return new UserId(guid);
    }
}

[StronglyTypedId]
public partial struct RebalancingGoalId : IGuid
{
    public static implicit operator RebalancingGoalId(Guid guid)
    {
        return new RebalancingGoalId(guid);
    }
}

[StronglyTypedId]
public partial struct RebalancingUserId : IGuid
{
    public static implicit operator RebalancingUserId(Guid guid)
    {
        return new RebalancingUserId(guid);
    }
}





