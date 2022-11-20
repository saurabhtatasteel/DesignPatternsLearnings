using DesignPatterns.Creational.FactoryMethod;
using DesignPatterns.Creational.Singleton;
using System;

namespace DesignPatterns
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("-------Singleton invocation test-------------");
			// Singleton test invocation
			SingletonClient.TestMethod();

			Console.WriteLine("-------Factory method invocation test-------------");

			// Factory method test invocation
			FactoryMethodClient.TestClient();

			Console.ReadLine();
		}
	}	
}
