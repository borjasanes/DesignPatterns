using System;
using System.Collections.Generic;
using System.Text;
using Creational.Factory;
using Creational.Factory.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DesignPatternsTest.Creational.Factory
{
    [TestClass]
    public class AbstractFactoryTest
    {
        [TestMethod]
        public void Given_AFactory_When_IsAMoto_Should_CreateAMoto()
        {
            var sut = new MotoWithAbstractFactory()
                .CreateVehicle();

            Assert.IsNotNull(sut as Moto);

            sut = new VanWithAbstractFactory(new MotoFactory())
                .CreateVehicle();

            Assert.IsNotNull(sut as Moto);
        }
    }
}
