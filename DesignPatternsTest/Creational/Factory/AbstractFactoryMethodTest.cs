using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Creational.Factory.Abstract;
using Creational.Factory.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DesignPatternsTest.Creational.Factory
{
    [TestClass]
    public class AbstractFactoryMethodTest
    {
        [TestMethod]
        public void Given_ASender_When_EmployeeFactory_Should_BuildEmployeeMail()
        {
            var mailProperties = new MailProperties
            {
                Name = "potato",
                Email = "potato@frito.com"
            };

            var smsProperties = new SmsProperties
            {
                Name = "potato",
                PhoneNumber = "+3399922000"
            };

            var sut = new EmployeeNotificationSender();

            var mail = sut.SendMailNotification(mailProperties, MailType.Welcome);

            Assert.AreEqual($"Welcome employee {mailProperties.Name}", mail.Body);

            var sms = sut.SendSmsNotification(smsProperties);

            Assert.AreEqual($"Welcome employee {smsProperties.PhoneNumber}", sms.Body);
        }
    }
}
