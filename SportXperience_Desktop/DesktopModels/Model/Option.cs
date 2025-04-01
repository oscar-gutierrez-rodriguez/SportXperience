using System;
using System.Collections.Generic;

namespace SportXperience.Model
{


    public partial class Option
    {
        public int OptionId { get; set; }

        public string Name { get; set; }

        public int? ProductId { get; set; }

        public virtual Product Product { get; set; }
    }
}