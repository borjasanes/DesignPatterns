using Creational.Factory;
using Creational.Factory.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DesignPatternsTest.Creational.Factory
{
    [TestClass]
    public class FactoryMethodTest
    {
        [TestMethod]
        [DataRow("borja", "mail@domain.com", "borja@hotmail.com")]
        public void Given_AMailFactory_When_IsWelcomeFactory_Should_CreateWelcomeTemplate(string name,string from, string to)
        {
            var sut = new WelcomeMailFactory().CreateMailProperties(name, from, to);
            
            Assert.IsNotNull(sut as WelcomeMail);
        }
    }
}