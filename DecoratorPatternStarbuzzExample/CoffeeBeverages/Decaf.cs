using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPatternStarbuzzExample
{
    public class Decaf : Beverage
    {
        public override long Cost()
        {
            return 3;
        }

        public Decaf()
        {
            Description = "Decaf,";
        }
    }
}
