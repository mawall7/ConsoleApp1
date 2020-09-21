using Microsoft.VisualBasic.FileIO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;

namespace Garage
{

    interface IGaragehandler
    {
       void AddVehicle( IVehicle x);
        void RemoveVehicle(IVehicle v);
        List <IVehicle> GetAll();
    }
    class Garagehandler:  IGaragehandler
    {
        private Garage<Vehicle> garage;
        private int vecount = 0;// 
        public Garagehandler(int Size) 
        {
            garage = new Garage<Vehicle>(Size);  // dvs ett Garage<T> där T är typen för klassen, Vehicle parametern för konstruktorn är Size. dessutom 
        }
        public void AddVehicle(IVehicle x)
        {
            for (int i = 0; i < garage.Count(); i++)
            {
                if (garage.Size < vecount)
                {
                    garage.AddVehicle((Vehicle)x);
                    vecount += 1;
                    

                }



            }

        }

        public List<IVehicle> GetAll()
        {
            throw new NotImplementedException();
        }

        public void RemoveVehicle(IVehicle v)
        {
            foreach (var item in garage)
            {
                garage.RemoveVehicle((Vehicle)v);
            }

        
           
        }

    }
}
