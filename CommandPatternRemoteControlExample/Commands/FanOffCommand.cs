using CommandPatternRemoteControlExample.Widget;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPatternRemoteControlExample.Commands
{
    public class FanOffCommand : ICommand
    {
        public Fan FanObj { get; set; }
        public FanOffCommand(Fan fan)
        {
            FanObj = fan;
        }
        public void Execute()
        {
            Console.WriteLine("Turning the fan off! Current speed: " + FanObj.Speed);
            FanObj.Off();
        }

        public void Undo()
        {
            FanObj.On(FanObj.PreviousSpeed);
        }
    }
}
