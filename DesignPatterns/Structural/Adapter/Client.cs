namespace DesignPatterns.Structural.Adapter
{
	public class AdapterClient
	{
		private ITarget target;

		public AdapterClient(ITarget target)
		{
			this.target = target;
		}

		public void MakeRequest()
		{
			target.MethodA();
		}
	}
}
