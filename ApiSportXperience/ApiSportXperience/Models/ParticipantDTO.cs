namespace ApiSportXperience.Models
{
    public class ParticipantDTO
    {
        public bool? Organizer { get; set; }

        public int EventId { get; set; }

        public string UserDni { get; set; } = null!;

        public string username { get; set; }

        public ParticipantDTO() { }
    }
}
