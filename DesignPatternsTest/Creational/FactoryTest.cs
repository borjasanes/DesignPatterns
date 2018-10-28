using System;
using System.Collections.Generic;
using System.Text;
using Creational.Builder;
using Creational.Factory;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DesignPatternsTest.Creational
{
    [TestClass]
    public class FactoryTest
    {
        [TestMethod]
        public void Given_AVehicleType_When_IsAMoto_Should_CreateAMoto()
        {
            var sut = VehicleFactory.CreateVehiche(VehicleType.Moto);

            Assert.IsNull(sut as Van);
            Assert.IsNull(sut as Car);
            Assert.IsNotNull(sut as Moto);
        }
    }
}
