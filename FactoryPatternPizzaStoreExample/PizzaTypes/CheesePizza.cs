using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPatternPizzaStoreExample.PizzaTypes
{
    public class CheesePizza : Pizza
    {
        PizzaIngredientFactory IngredientFactory;
        public CheesePizza(PizzaIngredientFactory IngredientFactory)
        {
            this.IngredientFactory = IngredientFactory;
        }
        public override void Prepare()
        {
            Console.WriteLine("Preparing " + PizzaName); 
            DoughMember = IngredientFactory.CreateDough();
            SauceMember = IngredientFactory.CreateSauce();
            CheeseMember = IngredientFactory.CreateCheese();
        }
    }
}
