using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPatternStarbuzzExample
{
    public class Espresso : Beverage
    {
        public override long Cost()
        {
            return 4;
        }

        public Espresso()
        {
            Description = "Espresso,";
        }
    }
}
