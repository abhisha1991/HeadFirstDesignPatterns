using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommandPatternRemoteControlExample.Widget;
namespace CommandPatternRemoteControlExample.Commands
{
    public class GarageDoorClosedCommand : ICommand
    {
        public GarageDoor GD { get; set; }

        public GarageDoorClosedCommand(GarageDoor GarageD)
        {
            GD = GarageD;
        }

        public void Execute()
        {
            GD.CloseDoor();
        }

        public void Undo()
        {
            GD.OpenDoor();
        }
    }
}
