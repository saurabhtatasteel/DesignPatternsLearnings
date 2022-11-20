using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioral.Decorator
{
    public class DecoratorClient
    {
        public void TestMethod()
        {
            IBasePizza basePizza = new BasePizza();
            Console.WriteLine("BasePizza price : " + basePizza.GetPrice());

            // Add mushroom to base pizza and get new price
            var mushroomPizzaDecorator = new MushroomPizzaDecorator(basePizza);
            Console.WriteLine("After Mushroom added price : " + mushroomPizzaDecorator.GetPrice());
        }
    }
}
