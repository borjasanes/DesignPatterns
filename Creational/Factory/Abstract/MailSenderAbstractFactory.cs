using System;
using Creational.Factory.Method;

namespace Creational.Factory.Abstract
{
    public abstract class NotificationAbstractFactory
    {
        public abstract string CreateNotification();
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
            return _notificationAbstractFactory.CreateNotification(); // abstract factory
        }
    }

    public class MailNotification : NotificationSender
    {
        public MailNotification(NotificationAbstractFactory factory) : base(factory)
        { }

        public MailNotification() : base(new TokenFactory())
        { }
    }

    public class SmsNotification : NotificationSender
    {
        public SmsNotification(NotificationAbstractFactory factory) : base(factory)
        { }

        public SmsNotification() : base(new TwoDigitsCodeFactory())
        { }
    }

    public class TokenFactory : NotificationAbstractFactory
    {
        public override string CreateNotification()
        {
            return Guid.NewGuid().ToString();
        }
    }

    public class TwoDigitsCodeFactory : NotificationAbstractFactory
    {
        private static readonly Random Random = new Random();

        public override string CreateNotification()
        {
            return Random.Next(1000, 9999).ToString();
        }
    }
}
