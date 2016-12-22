using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPatternPizzaStoreExample.IngredientConcreteClasses
{
    public class Onion : Veggies
    {
        public Onion()
        {
            Console.WriteLine("Adding some Onion");
        }
    }
}
