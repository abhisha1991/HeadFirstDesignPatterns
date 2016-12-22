using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPatternsDuckExample
{
    public class DecoyDuck : Duck
    {
        public override void Display()
        {
            Console.WriteLine("I am a Decoy duck!");
        }
    }
}
