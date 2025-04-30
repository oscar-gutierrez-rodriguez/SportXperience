using System;
using System.Collections.Generic;

namespace ApiSportXperience.Models;

public partial class MessageDTO
{
    public int MessageId { get; set; }

    public string? Comment { get; set; }

    public DateTime? PublishedDate { get; set; }

    public bool? PublicMessage { get; set; }

    public string? UserDni { get; set; }

    public string? DniOrganizer { get; set; }

    public string? UsernameOrganizer { get; set; }

}
