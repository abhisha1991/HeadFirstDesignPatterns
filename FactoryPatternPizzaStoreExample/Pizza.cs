using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FactoryPatternPizzaStoreExample.IngredientConcreteClasses;
namespace FactoryPatternPizzaStoreExample
{
    public abstract class Pizza
    {
        public string PizzaName { get; set; }
        public Dough DoughMember { get; set; }
        public Sauce SauceMember { get; set; }
        public List<Veggies> ListOfVeggiesMember { get; set; }
        public Cheese CheeseMember { get; set; }
        public Pepperoni PepperoniMember { get; set; }
        public Clams ClamsMember { get; set; }
        public abstract void Prepare();
        public void Bake()
        {
            Console.WriteLine("Bake for 25 mins at 350 degrees");
        }

        public void Cut()
        {
            if(PizzaName.ToLower().Contains("chicago"))
            {
                Console.WriteLine("Cutting pizza into square pieces");
            }
            else
            Console.WriteLine("Cutting pizza into diagnoal pieces");
            
        }

        public void Box()
        {
            Console.WriteLine("Placing pizza into official Pizzastore box!");
        }

    }
}
