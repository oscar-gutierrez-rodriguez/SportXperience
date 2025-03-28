using System;
using System.Collections.Generic;

namespace ApiSportXperience.Models;

public partial class Message
{
    public int MessageId { get; set; }

    public string? Comment { get; set; }

    public DateTime? PublishedDate { get; set; }

    public bool? PublicMessage { get; set; }

    public string? UserDni { get; set; }

    public int? EventId { get; set; }

    public virtual Event? Event { get; set; }

    public virtual User? UserDniNavigation { get; set; }
}
