using System;
using System.Collections.Generic;
using System.Text;

namespace BLL.Models
{
    public class FoodModel
    {
        public int FoodId { get; set; }

        public string Name { get; set; } = null!;

        public string Unit { get; set; } = null!;
    }
}
