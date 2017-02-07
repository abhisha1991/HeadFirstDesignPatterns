﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPatternStarbuzzExample
{
    public class Mocha : CondimentDecorator
    {
        Beverage B;

        public Mocha(Beverage BB)
        { 
            //Current object's (Mocha object's) Description is being set to Mocha
            Description = "Mocha,";
            
            //BB.Description is still some other value, like Houseblend
            B = BB;
        }

        //There is a GetDescription in parent and grandparent, when we call Mocha Obj ==> Obj.GetDescription(), then this method will be called, child method is preferred when you do overriding!
        public override string GetDescription() 
        {
            return B.GetDescription() + Description;
        }

        public override long Cost() //Same thing with the cost method!
        {
            return B.Cost() + 1;

        }
        public override void TestFunc()
        {
            Console.WriteLine("Hello from TestFunc");
        }

    }
}
