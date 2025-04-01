using System;
using System.Collections.Generic;

namespace SportXperience.Model
{
    public partial class Ubication
    {
        public int UbicationId { get; set; }

        public double? Latitude { get; set; }

        public double? Longitude { get; set; }

        public string CityName { get; set; }

        public virtual ICollection<Event> Events { get; set; } = new List<Event>();
    }
}
