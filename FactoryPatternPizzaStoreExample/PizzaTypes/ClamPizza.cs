using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPatternPizzaStoreExample.PizzaTypes
{
    class ClamPizza :Pizza
    {
        PizzaIngredientFactory IngredientFactory;
        public ClamPizza(PizzaIngredientFactory IngredientFactory)
        {
            this.IngredientFactory = IngredientFactory;
        }
        public override void Prepare()
        {
            Console.WriteLine("Preparing " + PizzaName);
            DoughMember = IngredientFactory.CreateDough();
            SauceMember = IngredientFactory.CreateSauce();
            CheeseMember = IngredientFactory.CreateCheese();
            ClamsMember = IngredientFactory.CreateClam();
        }
    }
}
