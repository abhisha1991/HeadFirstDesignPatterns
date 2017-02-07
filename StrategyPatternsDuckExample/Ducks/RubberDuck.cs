using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPatternsDuckExample
{
    public class RubberDuck : Duck
    {
        public override void Display()
        {
            Console.WriteLine("I am a rubber duck!");
        }
    }
}
