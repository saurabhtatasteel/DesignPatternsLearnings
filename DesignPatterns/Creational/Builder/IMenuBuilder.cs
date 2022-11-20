using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Creational.Builder
{
    public interface IMenuBuilder
    {
        void CreateFoodItems();
        void CreateUOMs();
        void CreateMenu();
        void AddMenuItemsToMenu();
        Menu GetCreatedMenu();
    }
}
