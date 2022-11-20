using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.AbstractFactoryPattern
{
	internal class BikeFactory : VehicleFactory
	{

		internal override VehicleFactory CreateVehicleFactory()
		{
			return new BikeFactory();
		}

		internal override Vehicle CreateVehicle(string vehicleType)
		{
			Vehicle vehicle = null;
			switch (vehicleType)
			{
				case "Yamaha":
					return new Yamaha();
				case "Bajaj":
					return new Bajaj();
				default:
					break;
			}
			return vehicle;
		}
	}
}
