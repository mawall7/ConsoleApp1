using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks.Dataflow;

namespace Garage
{
    interface ICar
    {
        public int GetMiles();
        public int Miles { get; set ; }  // inga konstruktorer i interface får finnas varför?
        
    }
    class Car : Vehicle, ICar
    {
        public int Miles { get; set; }
        
        public Car()
        {
            Console.WriteLine("input Miles Driven");
            this.Miles = int.Parse(Console.ReadLine());
            //this.Miles = Miles;
            Type_of_vehicle = this.GetType().Name;//"Car";

        }
        public int GetMiles() 
        {


            return Miles;
           ///???
        } //{ get => GetMiles; set => GetMiles }
    }
}
