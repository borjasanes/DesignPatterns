using System;
using Behavioral.Strategy;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DesignPatternsTest.Behavioral.Strategy
{
    [TestClass]
    public class StrategyPatternTest
    {
        [TestMethod]
        [DataRow("697111888", "welcome to strategy pattern")]
        public void Given_AnApp_When_SendNotification_Should_Send(string target, string content)
        {
            var smsNotificationSender = new NotificationSender(new SmsProviderOne());

            try
            {
                smsNotificationSender.SendNotification(target, content);
            }
            catch (Exception)
            {
                //Provider fail switch provider
                smsNotificationSender.ChangeProvider(new SmsProviderTwo());
            }

            smsNotificationSender.SendNotification(target, content);
        }
    }
}
