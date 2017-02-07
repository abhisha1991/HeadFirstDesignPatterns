using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPatternsDuckExample
{
    public class ModelDuck : Duck
    {
        public ModelDuck()
        {
            FB = new FlyWithWings();
            QB = new Quack();
            
        }
        public override void Display()
        {
            Console.WriteLine("I am a model duck!");
        }
    }
}
