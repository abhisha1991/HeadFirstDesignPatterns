using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPatternPizzaStoreExample.IngredientConcreteClasses
{
    public class Spinach : Veggies
    {
        public Spinach()
        {
            Console.WriteLine("Adding some Spinach");
        }
    }
}
