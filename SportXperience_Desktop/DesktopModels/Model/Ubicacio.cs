using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesktopModels.Model
{
    public class Ubicacio
    {
        [JsonProperty("idpoblacio")]
        public int IdPoblacio { get; set; }

        [JsonProperty("idprovincia")]
        public int IdProvincia { get; set; }

        [JsonProperty("nompoblacio")]
        public string NomPoblacio { get; set; }

        [JsonProperty("codipostal")]
        public string CodiPostal { get; set; }

        [JsonProperty("latitut")]
        public double Latitut { get; set; }

        [JsonProperty("longitut")]
        public double Longitut { get; set; }

        [JsonProperty("numhabitants")]
        public int? NumHabitants { get; set; }

        [JsonProperty("superficie")]
        public double? Superficie { get; set; }
    }
}
