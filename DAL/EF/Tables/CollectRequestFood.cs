using System;
using System.Collections.Generic;

namespace DAL.EF.Tables;

public partial class CollectRequestFood
{
    public int CollectRequestFoodId { get; set; }

    public int CollectRequestId { get; set; }

    public int FoodId { get; set; }

    public int Qnt { get; set; }

    public virtual Food Food { get; set; } = null!;
}
