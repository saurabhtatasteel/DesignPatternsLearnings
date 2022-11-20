namespace DesignPatterns.Behavioral.Decorator
{
	/// <summary>
	/// This is base pizza
	/// </summary>
	public class BasePizza : IBasePizza
    {
        public float GetPrice()
        {
            return 2F;
        }
    }
}
