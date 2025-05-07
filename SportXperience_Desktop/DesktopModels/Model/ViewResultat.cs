using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesktopModels.Model
{
    public class ViewResultat
    {
        public string Name { get; set; }

        public int Posicio { get; set; }

        public ViewResultat(string name, int? posicio)
        {
            this.Name = name;
            this.Posicio = (int)posicio;
        }

    }
}
