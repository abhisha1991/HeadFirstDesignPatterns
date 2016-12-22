using CommandPatternRemoteControlExample.Widget;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPatternRemoteControlExample.Commands
{
    public class FanOnCommand : ICommand
    {
      
        public Fan FanObj { get; set; }
        public FanOnCommand(Fan fan)
        {
            FanObj = fan;
            
        }
        public void Execute()
        {
            FanObj.On(6);
            Console.WriteLine("Setting fan speed to 100..."); //Invalid speed
            FanObj.On(100);
            Console.WriteLine("Setting fan speed to 7..."); //Shouldnt hard code, but for example sake!
            FanObj.On(7);
            
        }

        public void Undo()
        {
            FanObj.On(FanObj.PreviousSpeed);
        }
    }
}
