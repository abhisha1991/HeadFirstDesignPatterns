using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPatternStarbuzzExample
{
    public abstract class CondimentDecorator : Beverage
    {
        public override abstract string GetDescription();
        //This has been intentionally marked with the same name as its parent [The parent func is virtual, so we can give new behavior for this function in the children]
        //Reason: when we do Beverage BB = new Mocha(BB); - we actually have a beverage object, BB is a Beverage object, not a Mocha/Condiment Decorator obj
        //[NOT A Mocha object/CondimentDecorator object, SO WE CANT DO BB.TestFunc() as it doesnt belong to Beverage class] - Hence,we couldnt have named this function other than GetDescription()
        //Hence, we need to have the same function name as we have in the Beverage class, however, its functionality will vary based on implementation of the child as we are pointing it to Mocha class, Mocha being the child
        public override abstract long Cost(); //SAME WITH COST()
        public abstract void TestFunc();
    }
}
