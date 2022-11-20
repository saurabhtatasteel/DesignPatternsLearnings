using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.AbstractFactoryPattern
{
	internal abstract class VehicleFactory
	{
		//internal static VehicleFactory CreateVehicleFactory(string factoryType)
		//{
		//	VehicleFactory vehicleFactory = null;
		//	switch (factoryType)
		//	{
		//		case "car":
		//			vehicleFactory= new CarFactory();
		//			break;
		//		case "bike":
		//			vehicleFactory= new BikeFactory();
		//			break;

		//	}
		//	return vehicleFactory;

		//}

		internal abstract VehicleFactory CreateVehicleFactory(string vehicleType);

		internal abstract Vehicle CreateVehicle(string vehicleType);
	}
}
