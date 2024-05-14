using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Todo: Follow all comments!! 
             * Double click on the region (gray box) to view all comments
             */

            #region Vehicles

            /*
             *Create an abstract class called Vehicle
             * The vehicle class shall have three string properties: Year, Make, and Model
             * Set the defaults of the properties to something generic in the Vehicle class
             * Vehicle class shall have an abstract method called DriveAbstract with no implementation.
             * Vehicle class shall have a virtual method called DriveVirtual with a base implementation.
             */

            /* 
             * Now create 2 non-abstract classes: Car and Motorcycle, that inherit from Vehicle
             * Add a distinct property in the 2 derived classes such as HasTrunk for Car and HasSideCart for Motorcycle
             * Provide the implementations for the abstract methods
             * Only in the Motorcycle class will you override the virtual drive method
            */

            // Create a list of Vehicle called vehicles


            var vehicles = new List<Vehicle>();


            /*
             * Create 4 instances: 1 Car, 1 Motorcycle, and then 2 instances of type Vehicle (use explicit typing) but use constuctors from derived classes
             * 
             * Set the properties values with object initializer syntax
             */

            Car myCar = new Car() { Year = "2020", Make = "Toyota", Model = "Corolla", HasTrunk = true };
            Motorcycle harley = new Motorcycle() { Make = "H-D", Model = "TwoWheel", Year = "2001", HasSidecar = true };
            Vehicle bike = new Car() { Year = "2023", Make = "Schwinn", Model = "Beach Cruiser", HasTrunk = false };
            Vehicle truck = new Car() { HasTrunk = true, Make = "Ford", Model = "F-150", Year = "2020" };
            /*
             * Add the 4 vehicles to the list
             * Using a foreach loop iterate through the list and display each of the properties
             */

            vehicles.Add(myCar);
            vehicles.Add(harley);
            vehicles.Add(bike);
            vehicles.Add(truck);

            foreach (var item in vehicles)
            {
                Console.WriteLine($"This vehicle is a {item.Make} {item.Model} from {item.Year}");
            }

            // Call each of the drive methods for one car and one motorcycle


            myCar.DriveAbstract();
            myCar.DriveVirtual();

            harley.DriveAbstract();
            harley.DriveVirtual();


            #endregion            
            Console.ReadLine();
        }
    }
}
