using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPatternRemoteControlExample
{
    //A remote control has many slots - each slot refers to a widget - fan/light/bath tub/microwave etc.
    //Each of which can usually be turned on or off
    public class SimpleRemoteControl
    {
        public ICommand Slot { get; set; }
        public SimpleRemoteControl()
        { }

        public void SetCommand(ICommand command)
        {
            Slot = command;
        }

        public void ButtonWasPressed()
        {
            Slot.Execute();
        }
    }
}
