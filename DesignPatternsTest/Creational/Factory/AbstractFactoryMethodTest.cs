using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Creational.Factory.Abstract;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DesignPatternsTest.Creational.Factory
{
    [TestClass]
    public class AbstractFactoryMethodTest
    {
        [TestMethod]
        [DataRow("borja", "plain")]
        public void Given_Senders_When_DefaultFactory_Should_BeValidToken(string from, string to)
        {
            var sut = new MailNotificationSenderAbstractFactory().SendNotification(from, to);

            Assert.AreEqual(36, sut.Length);

            var sut2 = new SmsNotificationSenderAbstractFactory().SendNotification(from, to);

            Assert.AreEqual(4, sut2.Length);
        }

        [TestMethod]
        [DataRow("borja", "plain")]
        public void Given_ASender_When_ChangeProvider_Should_ReturnDiferentToken(string from, string to)
        {
            var sut = new MailNotificationSenderAbstractFactory(new FourDigitsCodeFactory()).SendNotification(from, to);

            Assert.AreEqual(4, sut.Length);

            var sut2 = new SmsNotificationSenderAbstractFactory(new GuidTokenFactory()).SendNotification("from", "to");

            Assert.AreEqual(36, sut2.Length);
        }
    }
}
