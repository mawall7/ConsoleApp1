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

            var gar1 = new Garage<int>(4);

            

        }    
        
    }
}
