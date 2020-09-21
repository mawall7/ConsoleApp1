using System;
using System.Collections.Generic;
using System.Text;

namespace Garage
{    
    
    class Motorcycle: Vehicle

    {
        int a = 0; 
        public int Nrofcylinders { get; set; }
        public Motorcycle(int Nrofcylinders)
        {
            this.Nrofcylinders = Nrofcylinders;
            Type_of_vehicle = "Motorcycle";// kan man skriva på ett annat sätt onödig kod?? går det att returnera ett klassnamn? vehiclex.Get = class MotType().name istället 
            
        }
    }
}
