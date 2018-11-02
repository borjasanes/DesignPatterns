using Creational.Factory;
using Creational.Factory.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DesignPatternsTest.Creational.Factory
{
    [TestClass]
    public class FactoryMethodTest
    {
        [TestMethod]
        public void Given_AVehicleFactory_When_IsVanFactory_Should_BuildAVan()
        {
            var sut = new VanFactory().CreateVehiche();
            
            Assert.IsNotNull(sut as Van);
        }
    }
}