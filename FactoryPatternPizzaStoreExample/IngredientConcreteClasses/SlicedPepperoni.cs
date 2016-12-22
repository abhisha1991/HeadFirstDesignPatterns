using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPatternPizzaStoreExample.IngredientConcreteClasses
{
    public class SlicedPepperoni : Pepperoni
    {
        public SlicedPepperoni()
        {
            Console.WriteLine("Adding some SlicedPepperoni");
        }
    }
}
