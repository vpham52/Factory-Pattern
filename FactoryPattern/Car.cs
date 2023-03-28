﻿using System;
namespace FactoryPattern 
{
	public class Car : IVehicle
    {
		public Car()
		{
		}

        public void Drive()
        {
            Console.WriteLine("Driving a new car!");
            
        }
    }
}

