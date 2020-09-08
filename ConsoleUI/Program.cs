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
             * Todo follow all comments!! 
             */

            #region Vehicles

            // Create a list of Vehicle called vehicles
            var vehicles = new List<Vehicle>();

            Car subaru = new Car() { HasTrunk = true, Year = 2020, Make = "Subaru", Model = "Outback" };
            Motorcycle harleyDavidson = new Motorcycle() {HasSideCart = true, Year = 2005, Make = "Harley Davidson", Model = "Chopper" };
            Vehicle sedan = new Car() { Make = "Toyota", Model = "Corolla", Year = 2005 };
            Vehicle sport = new Car() { HasTrunk = false, Make = "Dodge", Model = "Challenger", Year = 2019 };

            // Adding the 4 vehicles to the list.
            vehicles.Add(subaru);
            vehicles.Add(harleyDavidson); 
            vehicles.Add(sedan);
            vehicles.Add(sport);

            foreach(var veh in vehicles)
            {
                Console.WriteLine($"Make: {veh.Make} Model {veh.Model} Year {veh.Year}");
                veh.DriveAbstranct();
                Console.WriteLine(".......................................................");
            }

            #endregion            
            Console.ReadLine();
        }
    }
}
