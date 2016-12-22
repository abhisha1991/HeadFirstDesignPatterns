using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPatternPizzaStoreExample.IngredientConcreteClasses
{
    public class Eggplant : Veggies
    {
        public Eggplant()
        {
            Console.WriteLine("Adding some Eggplant");
        }
    }
}
