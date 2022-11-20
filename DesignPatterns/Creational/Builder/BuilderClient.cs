using System;

namespace DesignPatterns.Creational.Builder
{
	public static class BuilderClient
    {
        public static void TestClient()
        {
            Director director = new Director(new Menu1Builder());
            director.CreateMenuProducts();
            var menu = director.GetMenu();
            Console.WriteLine("FoodItems : " + menu.FoodItems);
            Console.WriteLine("UOMs : " + menu.UOMs);
            Console.WriteLine("MenuName : " + menu.MenuName);
            Console.WriteLine("MenuItems : " + menu.MenuItems);

        }


    }
}
