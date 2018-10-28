using Creational;
using Creational.Builder;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DesignPatternsTest.Creational
{
    [TestClass]
    public class BuilderTest
    {
        [TestMethod]
        public void BuildAVehicle()
        {
            var sut = VehicleBuilder.AVehicleBuilder()
                .WithDoors(2)
                .WithWheels(4)
                .Build();

            Assert.AreEqual(2, sut.Doors);
            Assert.AreEqual(4, sut.Wheels);
        }
    }
}
