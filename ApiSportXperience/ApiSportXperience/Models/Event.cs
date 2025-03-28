using System;
using System.Collections.Generic;

namespace ApiSportXperience.Models;

public partial class Event
{
    public int EventId { get; set; }

    public string? Name { get; set; }

    public DateTime? StartDate { get; set; }

    public DateTime? EndDate { get; set; }

    public byte[]? Image { get; set; }

    public string? Description { get; set; }

    public int? MinAge { get; set; }

    public int? MaxAge { get; set; }

    public int? MaxParticipantsNumber { get; set; }

    public double? Price { get; set; }

    public string? Reward { get; set; }

    public int? UbicationId { get; set; }

    public int? RecommendedLevelId { get; set; }

    public int? SportId { get; set; }

    public virtual ICollection<Lot> Lots { get; set; } = new List<Lot>();

    public virtual ICollection<Message> Messages { get; set; } = new List<Message>();

    public virtual ICollection<Participant> Participants { get; set; } = new List<Participant>();

    public virtual RecommendedLevel? RecommendedLevel { get; set; }

    public virtual Sport? Sport { get; set; }

    public virtual Ubication? Ubication { get; set; }
}
