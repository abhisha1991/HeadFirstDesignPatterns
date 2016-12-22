using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPatternStarbuzzExample
{
    public class DarkRoast : Beverage
    {
        public override long Cost()
        {
            return 2;
        }

        public DarkRoast()
        {
            Description = "DarkRoast,";
        }
    }
}
