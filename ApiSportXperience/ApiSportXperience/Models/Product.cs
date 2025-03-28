using System;
using System.Collections.Generic;

namespace ApiSportXperience.Models;

public partial class Product
{
    public int ProductId { get; set; }

    public string? Name { get; set; }

    public int? LotId { get; set; }

    public virtual Lot? Lot { get; set; }

    public virtual ICollection<Option> Options { get; set; } = new List<Option>();
}
