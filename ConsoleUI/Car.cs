using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleUI
{
    class Car : Vehicle
    {
        public bool HasTrunk { get; set; } = true;
        
        public override void DriveAbstranct()
        {
            Console.WriteLine("This car is in drive.");
        }


    }
}
