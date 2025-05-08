namespace ApiSportXperience.Models
{
    public class ParticipantOptionDTO
    {
        public int ParticipantOptionId { get; set; }

        public int EventId { get; set; }

        public string UserDni { get; set; } = null;

        public int OptionId { get; set; }

        public string Name { get; set; }

        public string nomProducte { get; set; }

        public string nomOpcio { get; set; }

        public ParticipantOptionDTO() { }

    }
}
