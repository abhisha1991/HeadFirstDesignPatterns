using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPatternPizzaStoreExample.IngredientConcreteClasses
{
    public class ThinCrustDough :Dough
    {
        public ThinCrustDough()
        {
            Console.WriteLine("Adding some ThinCrustDough");
        }
    }
}
