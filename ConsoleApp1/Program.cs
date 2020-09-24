using System;
using System.Collections.Generic;
using System.Data;

namespace Garage
{
    interface sets
    {
        public void setsize();
        
    }

    interface IInterface
    {
        public void setname(string name);
    }
    class Program
    {
        static void Main(string[] args)
        {

            Garagehandler gar1 = new Garagehandler(2);
            Car car1 = new Car(10);
            Console.WriteLine(car1.Nrwheels.ToString());


            

        }    
        
    }
}
