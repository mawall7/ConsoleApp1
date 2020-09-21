using Garage;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Dynamic;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.RegularExpressions;

namespace Garage
{

    class Garage<T> :IEnumerable<T> where T:Vehicle //  Typen måste vara av typen Vehicle ? <T> behöver anges när objektet skapas

    {
        
        private T[] vehicles { get; set; }
        public string Name { get; set; }
        
            
        public int Size { get; set; }

        
        ICollection d;

        public Garage(int size)
        {
            vehicles = new T[size];
            Size = size;
                  
            
        }

       
         public IEnumerable iteratevehicles()
        {
            foreach (var item in vehicles)
            {
                if (item!= null)
                    yield return (T)item;
                     
            }
            
        }
        

        public void AddVehicle(T x)// AddVehicle(T x)?
        {
            for (int i = 0; i < vehicles.Length; i++)
            {

                if (vehicles[i] != null)
                {
                    vehicles[i] = x;
                    break;
                }
                else
                    Console.WriteLine("all spots are taken");
            }




        }

        public void RemoveVehicle(T x)
        {
            foreach (var item in vehicles) 
            {
                if (Foundx(x) == true)
                    item = null;
            }
            
            //(null, x);
        }

        //public void create()
        //{
        //    int[] vehicle = new int[Size];
        //}
        
        

        public IEnumerator<T> GetEnumerator()  // ärver från IEnumerable så båda behövs
        {
            foreach (var item in vehicles)
            {
                if(item!=null)
                yield return item;
            }

        }

        IEnumerator IEnumerable.GetEnumerator()
        {

            return GetEnumerator(); //
            
        }

        //IEnumerator IEnumerable.GetEnumerator()
        //{
        //    throw new NotImplementedException();
        //}
    }
}
