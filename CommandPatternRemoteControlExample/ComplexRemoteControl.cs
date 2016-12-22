using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommandPatternRemoteControlExample.Commands;

namespace CommandPatternRemoteControlExample
{
    public class ComplexRemoteControl
    {
        public ICommand[] OnCommands { get; set; }
        public ICommand[] OffCommands { get; set; }
        public ICommand UndoCommand { get; set; }
        public ICommand NoComm { get; set; }
        public const int NumberOfWidgets = 7;
        public ComplexRemoteControl()
        {
            OnCommands = new ICommand[NumberOfWidgets];
            OffCommands = new ICommand[NumberOfWidgets];
            NoComm = new NoCommand();
            for(int i=0; i < NumberOfWidgets; i++)
            {
                OnCommands[i] = NoComm;

                OffCommands[i] = NoComm;
            } 
        }
        public void SetCommand(int slotIndex, ICommand onCommand, ICommand offCommand)
        {
            if (!IsIndexOutOfBounds(slotIndex) && OnCommands[slotIndex] != null && OffCommands[slotIndex] !=null)
            {
                OnCommands[slotIndex] = onCommand;
                OffCommands[slotIndex] = offCommand;
            }
        }
        public void OnButtonWasPressed(int slotIndex)
        {
            if (!IsIndexOutOfBounds(slotIndex) && OnCommands[slotIndex] != null && OffCommands[slotIndex] != null)
            {
                OnCommands[slotIndex].Execute();
                UndoCommand = OnCommands[slotIndex];
            }
        }

        public void OffButtonWasPressed(int slotIndex)
        {
            if (!IsIndexOutOfBounds(slotIndex) && OnCommands[slotIndex] != null && OffCommands[slotIndex] != null)
            {
                OffCommands[slotIndex].Execute();
                UndoCommand = OffCommands[slotIndex];
            }
        }

        public void UndoButtonWasPressed(int slotIndex)
        {
            Console.WriteLine("Performing undo for: " + UndoCommand.ToString());
            Console.WriteLine("Performing for slot # " + slotIndex);
            UndoCommand.Undo();
        }


        private bool IsIndexOutOfBounds(int slotIndex)
        {
            if (slotIndex > NumberOfWidgets - 1)
            {
                Console.WriteLine("Slot Index out of bounds!");
                return true; ;
            }
            return false;
        }
        public void DisplayContentsOfRemoteControl()
        {
            Console.WriteLine("*******Remote Control*******");
            for(int i=0; i< NumberOfWidgets; i++)
            {
                Console.WriteLine("Slot: " + i.ToString() + " -- On Command: " + OnCommands[i].ToString().Split('.').Last() + " -- Off Command: " + OffCommands[i].ToString().Split('.').Last());
            }
        }
    }
}
