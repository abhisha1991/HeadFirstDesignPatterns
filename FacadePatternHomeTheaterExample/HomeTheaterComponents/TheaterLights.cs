using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadePatternHomeTheaterExample.HomeTheaterComponents
{
    public class TheaterLights
    {
        public void On()
        {
            Console.WriteLine("TheaterLights is on");
        }
        public void Off()
        {
            Console.WriteLine("TheaterLights is off");
        }
        public void Dim()
        {
            Console.WriteLine("TheaterLights is set to dim");
        }
    }
}
