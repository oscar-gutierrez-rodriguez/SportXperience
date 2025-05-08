using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesktopModels.Model
{
    public class ViewTotalOption
    {
        public string nomProducte { get; set; }
        public string nomOpcio { get; set; }
        public int Total {  get; set; }
        public ViewTotalOption(string NomProducte, string NomOpcio, int total)
        {
            this.nomProducte = NomProducte;
            this.nomOpcio = NomOpcio;
            this.Total = total;
        }

    }
}
