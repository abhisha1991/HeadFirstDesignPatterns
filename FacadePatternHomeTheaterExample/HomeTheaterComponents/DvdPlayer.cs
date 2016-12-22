using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadePatternHomeTheaterExample.HomeTheaterComponents
{
    public class DvdPlayer
    {
        public void On()
        {
            Console.WriteLine("DvdPlayer is on");
        }
        public void Off()
        {
            Console.WriteLine("DvdPlayer is off");
        }

        public void Pause()
        {
            Console.WriteLine("DvdPlayer is paused");
        }
        public void Eject()
        {
            Console.WriteLine("DvdPlayer is ejecting DVD");
        }
        public void Play(string mov)
        {
            Console.WriteLine("DvdPlayer is playing " + mov);
        }

    }
}
