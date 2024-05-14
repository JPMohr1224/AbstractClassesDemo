using System;
namespace ConsoleUI
{
	public class Car : Vehicle
	{
       

        public override void DriveAbstract()
        {
            Console.WriteLine("Driving a car.");
        }

        public bool HasTrunk { get; set; } = true;
    }
}

