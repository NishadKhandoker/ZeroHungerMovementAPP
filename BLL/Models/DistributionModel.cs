using DAL.EF.Tables;
using System;
using System.Collections.Generic;
using System.Text;

namespace BLL.Models
{
    public class DistributionModel
    {
        public int DistributionId { get; set; }

        public int CollectRequestId { get; set; }

        public int EmployeeId { get; set; }

        public DateTime DistributedAt { get; set; }

        //public virtual Employee Employee { get; set; } = null!;
    }
}
