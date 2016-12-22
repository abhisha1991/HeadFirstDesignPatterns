using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPatternPizzaStoreExample.IngredientConcreteClasses
{
    public class BlackOlives : Veggies
    {
        public BlackOlives()
        {
            Console.WriteLine("Adding some BlackOlives");
        }
    }
}
