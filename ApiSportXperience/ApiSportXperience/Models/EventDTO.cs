namespace ApiSportXperience.Models
{
    public class EventDTO
    {
        public int EventId { get; set; }

        public string? Name { get; set; }

        public DateTime? StartDate { get; set; }

        public DateTime? EndDate { get; set; }

        public string? Image { get; set; }

        public string? Description { get; set; }

        public int? MinAge { get; set; }

        public int? MaxAge { get; set; }

        public int? MaxParticipantsNumber { get; set; }

        public double? Price { get; set; }

        public string? Reward { get; set; }

        public int? UbicationId { get; set; }

        public int? RecommendedLevelId { get; set; }

        public int? SportId { get; set; }

        public string RecommendedLevelName { get; set; }

        public string SportName { get; set; }

        public string cityName { get; set; }


        public EventDTO() { }
    }
}
