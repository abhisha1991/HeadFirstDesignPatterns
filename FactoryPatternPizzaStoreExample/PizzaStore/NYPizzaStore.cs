using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FactoryPatternPizzaStoreExample.PizzaTypes;

namespace FactoryPatternPizzaStoreExample.PizzaStore
{
    public class NYPizzaStore : PizzaStore
    {
        public NYPizzaStore()
        {
            //No op!, just used for debugging
        }
        protected override Pizza CreatePizza(string Type)
        {

            Pizza pizza = null;
            PizzaIngredientFactory IngredientFactory = new NYPizzaIngredientFactory();
            if(Type == "Cheese")
            {
                pizza = new CheesePizza(IngredientFactory);
                pizza.PizzaName = "New york style cheese pizza!";
            }
            else if(Type == "Veggie")
            {
                pizza = new VeggiePizza(IngredientFactory);
                pizza.PizzaName = "New york style veggie pizza!";
            }
            else if(Type == "Clam")
            {
                pizza = new ClamPizza(IngredientFactory);
                pizza.PizzaName = "New york style clam pizza!";
            }
            else if (Type == "Pepperoni")
            {
                pizza = new ClamPizza(IngredientFactory);
                pizza.PizzaName = "New york style Pepperoni pizza!";
            }

            return pizza;
        }
    }
}
