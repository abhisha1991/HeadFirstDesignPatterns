using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPatternPizzaStoreExample.IngredientConcreteClasses
{
    public class PlumTomatoSauce : Sauce
    {
        public PlumTomatoSauce()
        {
            Console.WriteLine("Adding some PlumTomatoSauce");
        }
    }
}
