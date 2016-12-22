using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPatternPizzaStoreExample.IngredientConcreteClasses
{
    public class ReggianoCheese :Cheese
    {
        public ReggianoCheese()
        {
            Console.WriteLine("Adding some ReggianoCheese");
        }
    }
}
