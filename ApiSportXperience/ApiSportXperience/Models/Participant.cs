using System;
using System.Collections.Generic;

namespace ApiSportXperience.Models;

public partial class Participant
{
    public bool? Organizer { get; set; }

    public int EventId { get; set; }

    public string UserDni { get; set; } = null!;

    public virtual Event Event { get; set; } = null!;

    public virtual ICollection<ParticipantOption> ParticipantOptions { get; set; } = new List<ParticipantOption>();

    public virtual ICollection<Result> Results { get; set; } = new List<Result>();

    public virtual User UserDniNavigation { get; set; } = null!;
}
