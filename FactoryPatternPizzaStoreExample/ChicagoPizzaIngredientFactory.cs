using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FactoryPatternPizzaStoreExample.IngredientConcreteClasses;

namespace FactoryPatternPizzaStoreExample
{
    class ChicagoPizzaIngredientFactory : PizzaIngredientFactory
    {
        public Cheese CreateCheese()
        {
            return new MozarellaCheese();
        }

        public Clams CreateClam()
        {
            return new FrozenClams();
        }

        public Dough CreateDough()
        {
            return new ThickCrustDough();
        }

        public Pepperoni CreatePepperoni()
        {
            return new SlicedPepperoni();
        }

        public Sauce CreateSauce()
        {
            return new PlumTomatoSauce();
        }

        public List<Veggies> CreateVeggies()
        {
            List<Veggies> veg = new List<Veggies> { new Eggplant(), new Spinach(), new BlackOlives(), new RedPepper() };
            return veg;
        }
    }
}
