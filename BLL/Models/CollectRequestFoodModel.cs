using System;
using System.Collections.Generic;
using System.Text;

namespace BLL.Models
{
    public class CollectRequestFoodModel
    {
        public int CollectRequestFoodId { get; set; }

        public int CollectRequestId { get; set; }

        public int FoodId { get; set; }

        public int Qnt { get; set; }
    }
}
