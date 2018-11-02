using System;
using System.Collections.Generic;
using System.Text;
using Creational.Singleton;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DesignPatternsTest.Creational.Singleton
{
    [TestClass]
    public class VehicleSingletonTest
    {
        [TestMethod]
        public void Given_AVehicle_When_ChangeName_Should_BeTheSame()
        {
            var firstVehicle = VehicleSingleton.Instance;
            var secondVehicle = VehicleSingleton.Instance;

            firstVehicle.Name = "volkswagen t5";

            Assert.AreEqual(firstVehicle.Name, secondVehicle.Name);
        }
    }
}
