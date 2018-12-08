using System;
using Creational.Factory.Method;

namespace Creational.Factory.Abstract
{
    /// <summary>
    /// the Abstract Factory pattern, a class delegates the responsibility
    /// of object instantiation to another object via composition ...
    /// </summary>
    public abstract class NotificationAbstractFactory
    {
        public abstract string CreateToken();
    }

    public class NotificationSender
    {
        private readonly NotificationAbstractFactory _notificationAbstractFactory;

        protected NotificationSender(NotificationAbstractFactory notificationAbstractFactory)
        {
            _notificationAbstractFactory = notificationAbstractFactory;
        }

        public string SendNotification(string from, string to)
        {
            return _notificationAbstractFactory.CreateToken();
        }
    }

    public class MailNotificationSender : NotificationSender
    {
        public MailNotificationSender(NotificationAbstractFactory factory) : base(factory)
        { }

        public MailNotificationSender() : base(new GuidTokenFactory())
        { }
    }

    public class SmsNotificationSender : NotificationSender
    {
        public SmsNotificationSender(NotificationAbstractFactory factory) : base(factory)
        { }

        public SmsNotificationSender() : base(new FourDigitsCodeFactory())
        { }
    }

    public class GuidTokenFactory : NotificationAbstractFactory
    {
        public override string CreateToken()
        {
            return Guid.NewGuid().ToString();
        }
    }

    public class FourDigitsCodeFactory : NotificationAbstractFactory
    {
        private static readonly Random Random = new Random();

        public override string CreateToken()
        {
            return Random.Next(1000, 9999).ToString();
        }
    }
}
