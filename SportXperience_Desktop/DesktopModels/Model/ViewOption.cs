using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesktopModels.Model
{
    public class ViewOption
    {
        public string Name { get; set; }
        public ViewOption(string name) 
        { 
            this.Name = name;
        }
    }
}
