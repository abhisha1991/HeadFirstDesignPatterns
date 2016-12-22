using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPatternPizzaStoreExample.IngredientConcreteClasses
{
    public class FrozenClams :Clams
    {
        public FrozenClams()
        {
            Console.WriteLine("Adding some FrozenClams");
        }
    }
}
