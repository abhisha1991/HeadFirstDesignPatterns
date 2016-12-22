using CommandPatternRemoteControlExample.Widget;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPatternRemoteControlExample.Commands
{
    public class LightOnCommand : ICommand
    {
        public Light LightObj { get; set; }

        public LightOnCommand(Light light)
        {
            LightObj = light;
        }
        public void Execute()
        {
            LightObj.On();
        }

        public void Undo()
        {
            LightObj.Off();
        }
    }
}
