using System;
using System.Collections.Generic;

namespace SportXperience.Model
{

    public partial class Gender
    {
        public int GenderId { get; set; }

        public string Name { get; set; }

        public virtual ICollection<User> Users { get; set; } = new List<User>();
    }
}
