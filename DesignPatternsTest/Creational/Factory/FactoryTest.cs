using Creational.Factory;
using Creational.Factory.Models;
using Creational.Factory.Simple;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DesignPatternsTest.Creational.Factory
{
    [TestClass]
    public class FactoryTest
    {
        [TestMethod]
        [DataRow(MailType.Welcome, "borja", "borja@plain.com", "Welcome app borja")]
        public void Given_AMailTemplate_When_IsWelcome_Should_CreateWelcomeBody(MailType mailType, string name, string email, string body)
        {
            var properties = new MailProperties
            {
                Name = name,
                Email = email
            };

            var sut = MailTemplateFactory.CreateTemplate(mailType, properties);

            Assert.IsNotNull(sut as WelcomeAppMailTemplate);
            Assert.AreEqual(sut.Body, body);
        }
    }
}
