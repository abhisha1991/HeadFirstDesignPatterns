using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPatternRemoteControlExample.Widget
{
    public class Light
    {
        string LightType;
        public Light(string Type) //Can be kitchen light, room light, bathroom light etc.
        {
            LightType = Type;
            Console.WriteLine("New light type: " + LightType);
        }
        public void On()
        {
            Console.WriteLine("The light is on for type: " + LightType);
        }
        public void Off()
        {
            Console.WriteLine("The light is off for type: " + LightType);
        }

    }
}
