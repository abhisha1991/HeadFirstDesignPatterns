using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPatternStarbuzzExample
{
    public abstract class Beverage
    {
        protected string Description { get; set; }
        public abstract long Cost();
        public virtual string GetDescription()
        {
            return Description;
        }
        

    }
   
}
