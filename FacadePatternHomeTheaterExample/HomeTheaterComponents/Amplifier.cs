using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadePatternHomeTheaterExample.HomeTheaterComponents
{
    public class Amplifier
    {
        public void On()
        {
            Console.WriteLine("Amplifier is on");
        }
        public void Off()
        {
            Console.WriteLine("Amplifier is off");
        }

        public void SetDVD(string Dvd)
        {
            Console.WriteLine("Set the amp to DVD: " + Dvd);
        }

        public void SetSurroundSound()
        {
            Console.WriteLine("Set the surround sound for amplifier");
        }

        public void SetVolume(int Vol)
        {
            Console.WriteLine("Set the amp volume to : " + Vol);
        }
    }
}
