using System;

namespace DesignPatterns.Structural.Adapter
{
	public class Adaptee
	{
		public string MethodB()
		{
			return "MethodB() of Adaptee is called";
		}
	}
}
