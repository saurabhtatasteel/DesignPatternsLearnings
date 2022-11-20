using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.AbstractFactoryPattern
{
	internal class Vehicle
	{
		public string ModelName { get; set; }
		public string Color { get; set; }	
	}

	internal class Yamaha : Vehicle
	{
		public bool IsRacingBike { get; set; }
	}

	internal class Bajaj : Vehicle
	{
		public bool IsFamilyBike { get; set; }
	}

	internal class Maruti : Vehicle
	{ 
	
	}

	internal class Mahindra : Vehicle
	{ }

}
