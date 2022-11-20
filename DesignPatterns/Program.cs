using DesignPatterns.Behavioral.Decorator;
using DesignPatterns.Creational.Builder;
using DesignPatterns.Creational.FactoryMethod;
using DesignPatterns.Creational.Singleton;
using DesignPatterns.Structural.Strategy;
using DesignPatterns.Structural.Template;
using DesignPatterns.Structural.Adapter;
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

			Console.WriteLine("-------Builder invocation test-------------");

			// Builder test invocation
			BuilderClient.TestClient();

			Console.WriteLine("-------Decorator invocation test-------------");

			// Decorator test invocation
			DecoratorClient.TestClient();

			Console.WriteLine("-------Strategy invocation test-------------");

			// Strategy test invocation
			StrategyClient.TestClient();

			Console.WriteLine("-------TemplateMethod invocation test-------------");

			// Template Method test invocation
			TemplateMethodClient.TestClient();

			Console.WriteLine("-------Adapter invocation test-------------");

			// Adapter test invocation
			ITarget target = new Adapter();
			AdapterClient adapterClient = new AdapterClient(target);
			adapterClient.MakeRequest();

			Console.ReadLine();
		}
	}	
}
