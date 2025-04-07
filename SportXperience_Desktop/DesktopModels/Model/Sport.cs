using System;
using System.Collections.Generic;

namespace SportXperience.Model
{
    public partial class Sport
    {
        public int SportId { get; set; }

        public string Name { get; set; }

        public virtual ICollection<Event> Events { get; set; } = new List<Event>();
    }
}