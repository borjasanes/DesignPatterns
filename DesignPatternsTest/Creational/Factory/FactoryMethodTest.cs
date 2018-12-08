using Creational.Factory;
using Creational.Factory.Method;
using Creational.Factory.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DesignPatternsTest.Creational.Factory
{
    [TestClass]
    public class FactoryMethodTest
    {
        [TestMethod]
        public void Given_AMailFactory_When_WelcomeEmployee_Shoud_CreateWelcome()
        {
            var properties = new MailProperties
            {
                Name = "potato",
                Email = "potato@frito.com"
            };

            var sut = new WebMailFactory().CreateTemplate(properties);
            
            Assert.IsNotNull(sut as WelcomeWebMailTemplate);
            Assert.IsNotNull("Welcome web potato", sut.Body);
        }

        [TestMethod]
        public void Given_AMailFactory_When_WelcomeCustomer_Shoud_CreateWelcome()
        {
            var properties = new MailProperties
            {
                Name = "borja",
                Email = "borja@plain.com"
            };

            var sut = new AppMailFactory().CreateTemplate(properties);

            Assert.IsNotNull(sut as WelcomeAppMailTemplate);
            Assert.IsNotNull("Welcome app borja", sut.Body);
        }
    }
}