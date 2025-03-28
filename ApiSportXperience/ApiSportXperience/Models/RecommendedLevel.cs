using System;
using System.Collections.Generic;

namespace ApiSportXperience.Models;

public partial class RecommendedLevel
{
    public int RecommendedLevelId { get; set; }

    public string? Name { get; set; }

    public virtual ICollection<Event> Events { get; set; } = new List<Event>();
}
