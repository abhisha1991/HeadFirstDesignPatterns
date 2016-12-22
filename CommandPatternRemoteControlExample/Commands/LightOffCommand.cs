using CommandPatternRemoteControlExample.Widget;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPatternRemoteControlExample.Commands
{
    public class LightOffCommand : ICommand
    {
        public Light LightObj { get; set; }

        public LightOffCommand(Light light)
        {
            LightObj = light;
        }
        public void Execute()
        {
            LightObj.Off();
        }
        public void Undo()
        {
            LightObj.On();
        }
    }
}
