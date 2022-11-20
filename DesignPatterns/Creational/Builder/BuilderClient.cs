using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Creational.Builder
{
    public class BuilderClient
    {
        public void TestClient()
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
