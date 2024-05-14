using System;
namespace ConsoleUI
{
	public abstract class Vehicle
	{
		public string Year { get; set; } = "Generic Year";
		public string Model { get; set; } = "Generic Model";
		public string Make { get; set; } = "Generic Make";

		public abstract void DriveAbstract();
		public virtual void DriveVirtual()
		{
			Console.WriteLine("You are virtually in drive.");
		}
			 

    }
}

