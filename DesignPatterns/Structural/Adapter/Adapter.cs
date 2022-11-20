using System;

namespace DesignPatterns.Structural.Adapter
{
	public class Adapter : Adaptee, ITarget
	{
		public void MethodA()
		{
			var output = MethodB();
			Console.WriteLine("Message from Adaptee's method named : " + output);
		}
	}
}
