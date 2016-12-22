using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AdapterPatternTurkeyDuckExample.Interfaces;

namespace AdapterPatternTurkeyDuckExample
{
    /// <summary>
    /// This is a turkey that has adapted to become a duck
    /// Used to demonstrate adapter pattern
    /// </summary>
    public class AdapterTurkey : Duck
    {
        public Turkey T { get; set; }

        public AdapterTurkey(Turkey turkey)
        {
            T = turkey;
        }

        public void Fly()
        {
            T.Fly();
        }

        public void Quack()
        {
            T.Gobble(); //Turkey doesnt quack, it gobbles
        }
    }
}
