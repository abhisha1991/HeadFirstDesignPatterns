using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPatternPizzaStoreExample.IngredientConcreteClasses
{
    public class FreshClams : Clams
    {
        public FreshClams()
        {
            Console.WriteLine("Adding some FreshClams");
        }
    }
}
