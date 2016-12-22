using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPatternRemoteControlExample.Widget
{
    public class GarageDoor
    {
        public void OpenDoor()
        {
            Console.WriteLine("Garage door is open!");
        }
        public void CloseDoor()
        {
            Console.WriteLine("Garage door is closed!");

        }

    }
}
