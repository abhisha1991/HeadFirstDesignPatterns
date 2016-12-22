using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadePatternHomeTheaterExample.HomeTheaterComponents
{
    public class PopcornPopper
    {
        public void On()
        {
            Console.WriteLine("PopcornPopper is on");
        }
        public void Off()
        {
            Console.WriteLine("PopcornPopper is off");
        }

        public void Pop()
        {
            Console.WriteLine("PopcornPopper is popping");
        }
    }
}
