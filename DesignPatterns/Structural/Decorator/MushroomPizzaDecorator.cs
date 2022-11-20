namespace DesignPatterns.Behavioral.Decorator
{
	/// <summary>
	/// Mushroom Pizza decorator
	/// </summary>
	public class MushroomPizzaDecorator : BasePizzaDecorator
    {

        IBasePizza _basePizza;
        public MushroomPizzaDecorator(IBasePizza basePizza) : base(basePizza)
        {
            _basePizza = basePizza;
        }

        public override float GetPrice()
        {
            return _basePizza.GetPrice() + 23;
        }
    }
}
