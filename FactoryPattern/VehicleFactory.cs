using System;
namespace FactoryPattern
{
	public  static class VehicleFactory
	{
		
		public static IVehicle GetVehicle(string vehicleType)
		{
			switch (vehicleType)
			{
				case "1":
					return new Unicycle();
				case "2":
					return new Motorcycle();
				case "4":
					return new Car();
				default:
					return new Car();
					
			}
		}
		
	}
}

