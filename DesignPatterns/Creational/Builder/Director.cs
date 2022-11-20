﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Creational.Builder
{
    public class Director
    {

        private readonly IMenuBuilder _menuBuilder;

        public Director(IMenuBuilder menuBuilder)
        {
            _menuBuilder = menuBuilder;
        }

        public void CreateMenuProducts()
        {
            _menuBuilder.CreateFoodItems();
            _menuBuilder.CreateUOMs();
            _menuBuilder.CreateMenu();
            _menuBuilder.AddMenuItemsToMenu();
        }

        public Menu GetMenu()
        {
            return _menuBuilder.GetCreatedMenu();
        }



    }
}
