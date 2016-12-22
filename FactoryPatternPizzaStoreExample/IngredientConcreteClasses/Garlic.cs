using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPatternPizzaStoreExample.IngredientConcreteClasses
{
    public class Garlic : Veggies
    {
        public Garlic()
        {
            Console.WriteLine("Adding some Garlic");
        }
    }
}
