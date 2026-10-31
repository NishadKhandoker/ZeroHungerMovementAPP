using System;
using System.Collections.Generic;

namespace DAL.EF.Tables;

public partial class Distribution
{
    public int DistributionId { get; set; }

    public int CollectRequestId { get; set; }

    public int EmployeeId { get; set; }

    public DateTime DistributedAt { get; set; }

    public virtual Employee Employee { get; set; } = null!;
}
