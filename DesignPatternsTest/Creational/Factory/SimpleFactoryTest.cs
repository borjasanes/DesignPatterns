using Creational.Factory.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using VehicleFactory = Creational.Factory.Simple.VehicleFactory;

namespace DesignPatternsTest.Creational.Factory
{
    [TestClass]
    public class SimpleFactoryTest
    {
        [TestMethod]
        public void Given_AVehicleType_When_IsAMoto_Should_CreateAMoto()
        {
            var sut = VehicleFactory.CreateVehiche(VehicleType.Moto);

            Assert.IsNotNull(sut as Moto);
        }
    }
}
