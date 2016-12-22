using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPatternRemoteControlExample.Commands
{
    /// <summary>
    /// This class has many command objects instead of only 1
    /// </summary>
    public class MacroCommands : ICommand
    {
        public ICommand[] ManyCommands { get; set; }

        public MacroCommands(ICommand[] Commands)
        {
            ManyCommands = Commands;

        }
        public void Execute()
        {
           foreach(var item in ManyCommands)
            {
                item.Execute();
            }
        }

        public void Undo()
        {
            foreach(var item in ManyCommands)
            {
                item.Undo();
            }
        }
    }
}
