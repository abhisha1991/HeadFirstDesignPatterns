using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPatternStarbuzzExample
{
    public class Whip : CondimentDecorator
    {
        Beverage B;

        public Whip(Beverage BB)
        {
            //Current object's (Whip object's) Description is being set to Whip
            Description = "Whip,"; 
            
            //BB.Description is still some other value, like Houseblend
            B = BB;
        }
        public override string GetDescription() 
        {
            return B.GetDescription() + Description;
        }

        public override long Cost() 
        {
            return B.Cost() + 10;

        }
        public override void TestFunc()
        {
            Console.WriteLine("Hello from TestFunc");
        }

    }
}
