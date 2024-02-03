using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Halle.Investments.Domain.Entities.Common;

public interface IGuid { }

[StronglyTypedId]
public partial struct RebalancingParametersId : IGuid
{
    public static implicit operator RebalancingParametersId(Guid guid)
    {
        return new RebalancingParametersId(guid);
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
public partial struct RebalancingGoalsId : IGuid
{
    public static implicit operator RebalancingGoalsId(Guid guid)
    {
        return new RebalancingGoalsId(guid);
    }
}

[StronglyTypedId]
public partial struct RebalancingManualTransactionId : IGuid
{
    public static implicit operator RebalancingManualTransactionId(Guid guid)
    {
        return new RebalancingManualTransactionId(guid);
    }
}




