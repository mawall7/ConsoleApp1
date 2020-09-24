using Microsoft.VisualStudio.TestTools.UnitTesting;
using Garage;
using System.ComponentModel.DataAnnotations;

namespace GarageTest
{
    using Garage;
    [TestClass]
    public class GarageTest
    {
        [TestMethod]
        public void AddVe()
        {
            Garagehandler g = new Garagehandler(2);
            Car car1 = new Car(1, "blue", "123", "Cab", 1);
            var r = car1.Miles;
                //var r = g.AddVehicle(car1);
            var expected = 1 ;
            
            Assert.AreEqual(expected,r);
            
        }
    }
}
