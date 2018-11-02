using Creational.Factory;
using Creational.Factory.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DesignPatternsTest.Creational.Factory
{
    [TestClass]
    public class FactoryTest
    {
        [TestMethod]
        public void Given_AVehicleType_When_IsAMoto_Should_CreateAMoto()
        {
            var sut = VehicleFactory.CreateVehiche(VehicleType.Moto);

            Assert.IsNotNull(sut as Moto);
        }
    }
}
