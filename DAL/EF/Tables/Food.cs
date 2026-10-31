using System;
using System.Collections.Generic;

namespace DAL.EF.Tables;

public partial class Food
{
    public int FoodId { get; set; }

    public string Name { get; set; } = null!;

    public string Unit { get; set; } = null!;

    public virtual ICollection<CollectRequestFood> CollectRequestFoods { get; set; } = new List<CollectRequestFood>();
}
