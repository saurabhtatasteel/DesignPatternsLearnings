using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Creational.Builder
{
    public class Menu1Builder : IMenuBuilder
    {

        Menu menu = new Menu();

        public void CreateFoodItems()
        {
            menu.FoodItems = "Menu 1 Food Items";
        }

        public void CreateUOMs()
        {
            menu.UOMs = "Menu 1 UOMs";
        }

        public void CreateMenu()
        {
            menu.MenuName = "Menu 1 Menu Name";
        }

        public void AddMenuItemsToMenu()
        {
            menu.MenuItems = "Menu 1 Menu Items";
        }

        public Menu GetCreatedMenu()
        {
            return menu;
        }

    }
}
