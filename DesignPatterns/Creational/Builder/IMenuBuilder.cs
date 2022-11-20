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
