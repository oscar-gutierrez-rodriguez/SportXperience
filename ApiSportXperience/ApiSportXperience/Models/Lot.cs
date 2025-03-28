using System;
using System.Collections.Generic;

namespace ApiSportXperience.Models;

public partial class Lot
{
    public int LotId { get; set; }

    public int? EventId { get; set; }

    public virtual Event? Event { get; set; }

    public virtual ICollection<Product> Products { get; set; } = new List<Product>();
}
