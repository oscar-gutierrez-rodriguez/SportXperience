using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesktopModels.Model
{
    public class Ubicacio
    {
        public int idpoblacio { get; set; }
        public int idprovincia { get; set; }
        public string nompoblacio { get; set; }
        public string codipostal { get; set; }
        public double latitut { get; set; }
        public double longitut { get; set; }
        public int? numhabitants { get; set; }
        public double? superficie { get; set; }
    }
}
