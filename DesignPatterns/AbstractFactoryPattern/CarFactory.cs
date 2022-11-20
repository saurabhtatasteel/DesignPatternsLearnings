using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.AbstractFactoryPattern
{
	internal class CarFactory : VehicleFactory
	{

		internal override VehicleFactory CreateVehicleFactory(string vehicleType)
		{
			return new CarFactory();
		}

		internal override Vehicle CreateVehicle(string vehicleType)
		{
			Vehicle vehicle = null;
			switch (vehicleType)
			{
				case "Maruti":
					return new Maruti();
				case "Mahindra":
					return new Mahindra();
				default:
					break;
			}
			return vehicle;
		}
	}
}
