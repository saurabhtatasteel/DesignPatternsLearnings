namespace DesignPatterns.Behavioral.Decorator
{
	/// <summary>
	/// Paneer pizza decorator
	/// </summary>
	public class PaneerPizzaDecorator : BasePizzaDecorator
    {

        IBasePizza _basePizza;
        public PaneerPizzaDecorator(IBasePizza basePizza) : base(basePizza)
        {
            _basePizza = basePizza;
        }

        public override float GetPrice()
        {
            return _basePizza.GetPrice() + 34;
        }

    }
}
