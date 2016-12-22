using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AdapterPatternTurkeyDuckExample.Interfaces;

namespace AdapterPatternTurkeyDuckExample
{
    public class MallardDuck : Duck
    {
        public void Fly()
        {
            Console.WriteLine("Duck is flying!");
        }

        public void Quack()
        {
            Console.WriteLine("Duck is quacking!");
        }
    }
}
