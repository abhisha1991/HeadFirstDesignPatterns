using FactoryPatternPizzaStoreExample.PizzaTypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPatternPizzaStoreExample.PizzaStore
{
    public class ChicagoPizzaStore : PizzaStore
    {
        protected override Pizza CreatePizza(string Type)
        {

            Pizza pizza = null;
            PizzaIngredientFactory IngredientFactory = new ChicagoPizzaIngredientFactory();
            if (Type == "Cheese")
            {
                pizza = new CheesePizza(IngredientFactory);
                pizza.PizzaName = "Chicago style cheese pizza!";
            }
            else if (Type == "Veggie")
            {
                pizza = new VeggiePizza(IngredientFactory);
                pizza.PizzaName = "Chicago style veggie pizza!";
            }
            else if (Type == "Clam")
            {
                pizza = new ClamPizza(IngredientFactory);
                pizza.PizzaName = "Chicago style clam pizza!";
            }
            else if (Type == "Pepperoni")
            {
                pizza = new ClamPizza(IngredientFactory);
                pizza.PizzaName = "Chicago style Pepperoni pizza!";
            }
            return pizza;
        }
    }
}
