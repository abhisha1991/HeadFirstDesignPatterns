using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FactoryPatternPizzaStoreExample.IngredientConcreteClasses;

namespace FactoryPatternPizzaStoreExample
{
    public class NYPizzaIngredientFactory : PizzaIngredientFactory
    {
        public Cheese CreateCheese()
        {
            return new ReggianoCheese();
        }

        public Clams CreateClam()
        {
            return new FreshClams();
        }

        public Dough CreateDough()
        {
            return new ThinCrustDough();
        }

        public Pepperoni CreatePepperoni()
        {
            return new SlicedPepperoni();
        }

        public Sauce CreateSauce()
        {
            return new MarinaraSauce();
        }

        public List<Veggies> CreateVeggies()
        {
            List<Veggies> veg = new List<Veggies> { new Garlic(), new Onion(), new Mushroom(), new RedPepper() };
            return veg;
        }
    }
}
