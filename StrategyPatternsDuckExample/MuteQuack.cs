using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPatternsDuckExample
{
    public class MuteQuack : QuackBehavior
    {
        public void quack()
        {
            Console.WriteLine("Muted quack! - Quack behavior");
        }
    }
}
