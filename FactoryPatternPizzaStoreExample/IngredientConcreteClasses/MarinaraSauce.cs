using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPatternPizzaStoreExample.IngredientConcreteClasses
{
    public class MarinaraSauce :Sauce
    {
        public MarinaraSauce()
        {
            Console.WriteLine("Adding some MarinaraSauce");
        }
    }
}
