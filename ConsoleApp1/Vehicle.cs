using System;
using System.Collections.Generic;
using System.Text;

namespace Garage
{
    interface IVehicle
    {
        public string Color { get; set; }
        public string Regnr { get; set; }
        public string Type_of_vehicle { get; set; }
        public int Nrwheels { get; set; }
    }

    class Vehicle: IVehicle
    {   
        public string Color { get; set; }
        public string Regnr { get; set; }
        public string Type_of_vehicle { get; set; }

        public int Nrwheels { get; set; }

        public int Owner { get; set; }

        public Vehicle()
        {
            Console.WriteLine("you have a new vehicle that will be added through the handler: ");

        }

    }

}
