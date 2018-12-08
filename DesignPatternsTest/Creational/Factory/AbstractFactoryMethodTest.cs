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
        public void Given_Senders_When_SameTokenProvider_Should_BeSameTokenFormat(string from, string to)
        {
            var sut = new MailNotification(new TwoDigitsCodeFactory()).SendNotification(from, to);

            var sut2 = new SmsNotification(new TwoDigitsCodeFactory()).SendNotification(from, to);

            Assert.AreEqual(4, sut.Length);
            Assert.AreEqual(4, sut2.Length);
        }

        [TestMethod]
        [DataRow("borja", "plain")]
        public void Given_ASender_When_ChangeProvider_Should_ReturnDiferentToken(string from, string to)
        {
            var sut = new MailNotification().SendNotification(from, to);

            var sut2 = new MailNotification(new TwoDigitsCodeFactory()).SendNotification("from", "to");

            Assert.AreEqual(36, sut.Length);
            Assert.AreEqual(4, sut2.Length);
        }
    }
}
