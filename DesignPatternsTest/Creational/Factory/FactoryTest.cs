using Creational.Factory;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DesignPatternsTest.Creational.Factory
{
    [TestClass]
    public class FactoryTest
    {
        [TestMethod]
        public void Given_AVehicleType_When_IsAMoto_Should_CreateAMoto()
        {
            var sut = ConnectionFactory.GetConnectionString("ES");

            Assert.IsNotNull(sut);
            Assert.AreEqual("SpainDb", sut);
        }
    }
}
