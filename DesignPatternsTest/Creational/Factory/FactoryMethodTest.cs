using Creational.Factory;
using Creational.Factory.Method;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DesignPatternsTest.Creational.Factory
{
    [TestClass]
    public class FactoryMethodTest
    {
        [TestMethod]
        public void Given_ATokenFactory_When_FourDigit_Should_Create4DigitCode()
        {
            var sut = new FourDigitTokenFactory().CreateToken();
            
            Assert.IsNotNull(4, sut);
        }

        [TestMethod]
        public void Given_ATokenFactory_When_Guid_Should_CreateGuidCode()
        {
            var sut = new GuidTokenFactory().CreateToken();

            Assert.IsNotNull(36, sut);
        }
    }
}