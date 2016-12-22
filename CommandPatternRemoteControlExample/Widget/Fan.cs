using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPatternRemoteControlExample.Widget
{
    public class Fan
    {
        string FanType;
        public static readonly int MaxSpeed = 10;
        public static readonly int MinSpeed = 0;
        public static readonly int MidSpeed = 5;
        public int PreviousSpeed { get; set;}
        public void SetSpeed(int NewSpeed)
        {
            if (NewSpeed < MinSpeed)
            {
                Console.WriteLine("Speed cant be under 0");
                Speed = MinSpeed;
            }
            if (NewSpeed > MaxSpeed)
            {
                Console.WriteLine("Speed cant be over 10");
                Speed = MaxSpeed;
            }
            else
            {
                Speed = NewSpeed;
            }
        }
        public int Speed { get; private set;}
        public Fan(string Type) //Can be different fans - ceiling, window, standing
        {
            FanType = Type;
            Speed = MinSpeed;
            PreviousSpeed = Speed;
            Console.WriteLine("New Fan type: " + FanType);
        }
        public void On(int NewSpeed = 5)
        {
            PreviousSpeed = Speed;
            SetSpeed(NewSpeed);
            if(Speed == MinSpeed)
            {
                Console.WriteLine("The user changed the speed to 0, the fan is off now");
                return;
            }
            Console.WriteLine("The Fan is on for type: " + FanType);
           
            Console.WriteLine("The speed is: " + Speed);
        }
        public void Off()
        {
            Console.WriteLine("The Fan is off for type: " + FanType);
            PreviousSpeed = Speed;
            Speed = MinSpeed;
            Console.WriteLine("The speed is: " + Speed);
        }
        
    }
}
