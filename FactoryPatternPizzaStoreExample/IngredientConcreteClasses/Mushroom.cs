using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPatternPizzaStoreExample.IngredientConcreteClasses
{
    public class Mushroom : Veggies
    {
        public Mushroom()
        {
            Console.WriteLine("Adding some Mushroom");
        }
    }
}
