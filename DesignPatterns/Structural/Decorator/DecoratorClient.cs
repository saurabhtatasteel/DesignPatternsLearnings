using System;

namespace DesignPatterns.Behavioral.Decorator
{
	public static class DecoratorClient
    {
        public static void TestClient()
        {
            IBasePizza basePizza = new BasePizza();
            Console.WriteLine("BasePizza price : " + basePizza.GetPrice());

            // Add mushroom to base pizza and get new price
            var mushroomPizzaDecorator = new MushroomPizzaDecorator(basePizza);
            Console.WriteLine("After Mushroom added price : " + mushroomPizzaDecorator.GetPrice());

            // Add paneer to base pizza and get new price
            var paneerPizzaDecorator = new PaneerPizzaDecorator(basePizza);
            Console.WriteLine("After Paneer added price : " + paneerPizzaDecorator.GetPrice());

        }
    }
}
