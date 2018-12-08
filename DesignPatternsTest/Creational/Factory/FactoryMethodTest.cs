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

            var sut = new EmployeeMailFactory().CreateTemplate(properties, MailType.Welcome);
            
            Assert.IsNotNull(sut as WelcomeEmployeeMailTemplate);
            Assert.IsNotNull("Welcome employee potato", sut.Body);
        }

        [TestMethod]
        public void Given_AMailFactory_When_WelcomeCustomer_Shoud_CreateWelcome()
        {
            var properties = new MailProperties
            {
                Name = "borja",
                Email = "borja@plain.com"
            };

            var sut = new CustomerMailFactory().CreateTemplate(properties, MailType.Welcome);

            Assert.IsNotNull(sut as WelcomeCustomerMailTemplate);
            Assert.IsNotNull("Welcome customer borja", sut.Body);
        }
    }
}