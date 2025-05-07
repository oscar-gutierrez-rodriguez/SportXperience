namespace ApiSportXperience.Models
{
    public class ResultDTO
    {
        public int ResultId { get; set; }

        public int? Position { get; set; }

        public string UserDni { get; set; }

        public int? EventId { get; set; }

        public string Name { get; set; }

        public ResultDTO() { }
    }
}
