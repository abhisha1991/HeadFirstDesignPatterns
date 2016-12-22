using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPatternPizzaStoreExample.IngredientConcreteClasses
{
    class RedPepper : Veggies
    {
        public RedPepper()
        {
            Console.WriteLine("Adding some RedPepper");
        }
    }
}
