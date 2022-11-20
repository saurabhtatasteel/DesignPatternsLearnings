namespace DesignPatterns.Behavioral.Decorator
{
	/// <summary>
	/// Base pizza decorator
	/// </summary>
	public abstract class BasePizzaDecorator : IBasePizza
    {
        IBasePizza _basePizza;
        public BasePizzaDecorator(IBasePizza basePizza)
        {
            _basePizza = basePizza;
        }
        public virtual float GetPrice()
        {
            return this._basePizza.GetPrice();
        }

    }
}
