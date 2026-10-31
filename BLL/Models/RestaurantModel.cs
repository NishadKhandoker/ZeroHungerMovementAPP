using System;
using System.Collections.Generic;
using System.Text;

namespace BLL.Models
{
    public class RestaurantModel
    {
        public int RestaurantId { get; set; }

        public string Name { get; set; } = null!;

        public string ContactNo { get; set; } = null!;

        public string Address { get; set; } = null!;
    }
}
