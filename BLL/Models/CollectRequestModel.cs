using System;
using System.Collections.Generic;
using System.Text;

namespace BLL.Models
{
    public class CollectRequestModel
    {
        public int CollectRequestId { get; set; }

        public int RestaurantId { get; set; }

        public int? EmployeeId { get; set; }

        public DateTime RequestTime { get; set; }

        public DateTime PreserveTime { get; set; }

        public string Status { get; set; } = null!;
    }
}
