using System;
using System.Collections.Generic;

namespace ApiSportXperience.Models;

public partial class Result
{
    public int ResultId { get; set; }

    public int? Position { get; set; }

    public string? UserDni { get; set; }

    public int? EventId { get; set; }

    public virtual Participant? Participant { get; set; }
}
