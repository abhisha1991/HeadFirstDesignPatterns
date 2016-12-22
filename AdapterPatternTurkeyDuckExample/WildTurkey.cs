using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AdapterPatternTurkeyDuckExample.Interfaces;
namespace AdapterPatternTurkeyDuckExample
{
    public class WildTurkey : Turkey
    {
        public void Fly()
        {
            Console.WriteLine("Flying short distance!");
            //turkeys usually fly short distances
        }

        public void Gobble()
        {
            Console.WriteLine("Making gobble noise!");
        }
    }
}
