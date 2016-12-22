using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FactoryPatternPizzaStoreExample.IngredientConcreteClasses;
namespace FactoryPatternPizzaStoreExample
{
    public interface PizzaIngredientFactory 
    {
        Dough CreateDough(); //This is a factory method - because - based on whether you have a NYPizzaIngredientFactory or ChicagoPizzaIngredientFactory - you are getting different versions of the dough 
        Sauce CreateSauce();
        Cheese CreateCheese();
        List<Veggies> CreateVeggies();
        Pepperoni CreatePepperoni();
        Clams CreateClam();
    }
}
