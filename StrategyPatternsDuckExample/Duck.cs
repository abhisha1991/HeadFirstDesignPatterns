using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPatternsDuckExample
{
    public abstract class Duck
    {
        public FlyBehavior FB;
        public QuackBehavior QB;
       
        public abstract void Display();

        public void PerformFly()
        {
            FB.fly();
        }
        public void PerformQuack()
        {
            QB.quack();
        }
        public void SetFlyBehavior(FlyBehavior fb)
        {
            FB = fb;
        }
        public void SetQuackBehavior(QuackBehavior qb)
        {
            QB = qb;
        }
        public void Swim()
        {
            Console.WriteLine("All ducks float, even decoys!");
        }
    }
}
