using System;
namespace ConsoleUI
{
	public class Motorcycle : Vehicle 
	{
        
         public Motorcycle()
        {

        }
        

        public override void DriveAbstract() 
        {
            Console.WriteLine("Driving a cycle");
        }

        public override void DriveVirtual()
        {
            Console.WriteLine("You are virtualy ready to ride this cycle.");
        }


        public bool HasSidecar { get; set; } = true;

        
    }
}

