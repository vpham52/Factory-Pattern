using System;
namespace FactoryPattern
{
	public class Unicycle : IVehicle
	{
		public Unicycle()
		{
		}

        public void Drive()
        {
            Console.WriteLine("Driving a new electric unicycle!");
        }
    }
}

