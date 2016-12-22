using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPatternPizzaStoreExample.PizzaStore
{
    public abstract class PizzaStore
    {
        protected abstract Pizza CreatePizza(string Type);
        public Pizza OrderPizza(string Type)
        {
            Pizza pizza;
            pizza = CreatePizza(Type);
            pizza.Prepare();
            pizza.Bake();
            pizza.Cut();
            pizza.Box();
            return pizza;
        }
    }
}
 