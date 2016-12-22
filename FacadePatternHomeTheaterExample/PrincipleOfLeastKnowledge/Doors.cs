using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadePatternHomeTheaterExample.PrincipleOfLeastKnowledge
{
    public class Doors
    {
        public void DoorsMethod()
        {
            Console.WriteLine("DoorsMethod");
        }

        public void Lock()
        {
            Console.WriteLine("Doors locked");
        }


    }
}
