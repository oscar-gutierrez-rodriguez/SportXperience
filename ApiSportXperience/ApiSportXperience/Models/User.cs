using System;
using System.Collections.Generic;

namespace ApiSportXperience.Models;

public partial class User
{
    public string Dni { get; set; } = null!;

    public string? FirstName { get; set; }

    public string? LastName { get; set; }

    public string? Username { get; set; }

    public string? Mail { get; set; }

    public string? Password { get; set; }

    public int? GenderId { get; set; }

    public DateTime? BirthDate { get; set; }

    public virtual Gender? Gender { get; set; }

    public virtual ICollection<Message> Messages { get; set; } = new List<Message>();

    public virtual ICollection<Participant> Participants { get; set; } = new List<Participant>();
}
