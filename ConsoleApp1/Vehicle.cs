using System;
using System.Collections.Generic;
using System.Text;

namespace Garage
{
    public interface IVehicle
    {
        public string Color { get; set; }
        public string Regnr { get; set; }
        public string Type_of_vehicle { get; set; }
        public int Nrwheels { get; set; }
    }

    public class Vehicle: IVehicle
    {   
        public string Color { get; set; }
        public string Regnr { get; set; }
        public string Type_of_vehicle { get; set; }

        public int Nrwheels { get; set; }

       

        public Vehicle(string color,string regnr, string type_of_vehicle , int nrwheels)
        {
            Color = Color;
            Regnr = regnr;
            Type_of_vehicle = type_of_vehicle;
            Nrwheels = nrwheels;
            Console.WriteLine("you have a new vehicle that will be added through the handler: ");

        }

    }

}
