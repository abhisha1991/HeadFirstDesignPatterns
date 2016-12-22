using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadePatternHomeTheaterExample.HomeTheaterComponents
{
    public class Projector
    {
        public void On()
        {
            Console.WriteLine("Projector is on");
        }
        public void Off()
        {
            Console.WriteLine("Projector is off");
        }

        public void WidescreenMode()
        {
            Console.WriteLine("Projector is in WidescreenMode ");
        }
    }
}
