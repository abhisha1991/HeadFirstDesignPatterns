using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPatternStarbuzzExample
{
    public class Houseblend : Beverage
    {
        public override long Cost()
        {
            return 5;
        }

        public Houseblend()
        {
            Description = "Houseblend,";
        }
    }
}
