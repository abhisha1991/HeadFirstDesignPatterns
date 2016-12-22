using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommandPatternRemoteControlExample.Widget;
namespace CommandPatternRemoteControlExample.Commands
{
    public class GarageDoorOpenCommand : ICommand
    {
        public GarageDoor GD { get; set; }

        public GarageDoorOpenCommand(GarageDoor GarageD)
        {
            GD = GarageD;
        }

        public void Execute()
        {
            GD.OpenDoor();
        }
        public void Undo()
        {
            GD.CloseDoor();
        }
    }
}
