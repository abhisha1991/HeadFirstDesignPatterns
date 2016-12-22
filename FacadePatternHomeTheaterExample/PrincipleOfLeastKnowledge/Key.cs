using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadePatternHomeTheaterExample.PrincipleOfLeastKnowledge
{
    public class Key
    {
        public void KeyMethod()
        {
            Console.WriteLine("KeyMethod");
        }

        public bool Turns()
        {
            return true;
        }
    }
}
