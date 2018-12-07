using Creational.Factory;
using Creational.Factory.Method;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DesignPatternsTest.Creational.Factory
{
    [TestClass]
    public class FactoryMethodTest
    {
        [TestMethod]
        [DataRow("borja", "mail@domain.com", "borja@hotmail.com", "Welcome borja.")]
        public void Given_AMailFactory_When_IsWelcomeFactory_Should_CreateWelcomeTemplate(string name,string from, string to, string body)
        {
            var sut = new WelcomeMailFactory().BuildMailProperties(name, from, to);
            
            Assert.IsNotNull(sut as WelcomeMail);
            Assert.IsNotNull(body, sut.Body);
        }
    }
}