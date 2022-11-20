using System;

namespace DesignPatterns.Creational.Singleton
{
	public sealed class Singleton
	{
		private static int _counter = 0;
		private static Singleton _singleton = null;
		private static readonly object InstanceLock = new object();

		public static Singleton Instance
		{
			get
			{
				lock (InstanceLock)
				{
					if (_singleton == null)
					{
						_singleton = new Singleton();
						Console.WriteLine("I created a new singleton instance");
					}
					else
						Console.WriteLine("I already have singleton instance");

					return _singleton;
				}
			}
		}

		private Singleton()
		{
			_counter++;
			Console.WriteLine("Counter : " + _counter.ToString());
		}

		public void PrintDetails(string message)
		{
			Console.WriteLine(String.Format("{0}: {1}", message, _counter));
		}



	}
}
