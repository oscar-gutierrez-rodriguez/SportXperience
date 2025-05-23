using System;
using System.Collections.Generic;

namespace ApiSportXperience.Models;

public partial class ParticipantOption
{
    public int ParticipantOptionId { get; set; }

    public int EventId { get; set; }

    public string UserDni { get; set; } = null!;

    public int OptionId { get; set; }

    public virtual Option Option { get; set; } = null!;

    public virtual Participant Participant { get; set; } = null!;
}
