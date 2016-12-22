using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPatternPizzaStoreExample.IngredientConcreteClasses
{
    public class ThickCrustDough : Dough
    {
        public ThickCrustDough()
        {
            Console.WriteLine("Adding some ThickCrustDough");
        }
    }
}
