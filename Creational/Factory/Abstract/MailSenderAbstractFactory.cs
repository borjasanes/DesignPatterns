using System;
using Creational.Factory.Method;

namespace Creational.Factory.Abstract
{
    /// <summary>
    /// the Abstract Factory pattern, a class delegates the responsibility
    /// of object instantiation to another object via composition
    /// </summary>
    public abstract class TokenFactory
    {
        public abstract string CreateToken();
    }

    public class NotificationSenderAbstractFactory
    {
        private readonly TokenFactory _tokenFactory;

        protected NotificationSenderAbstractFactory(TokenFactory tokenFactory)
        {
            _tokenFactory = tokenFactory;
        }

        public string SendNotification(string from, string to)
        {
            return _tokenFactory.CreateToken();
        }
    }

    public class MailNotificationSenderAbstractFactory : NotificationSenderAbstractFactory
    {
        public MailNotificationSenderAbstractFactory(TokenFactory factory) : base(factory)
        { }

        public MailNotificationSenderAbstractFactory() : base(new GuidTokenFactory())
        { }
    }

    public class SmsNotificationSenderAbstractFactory : NotificationSenderAbstractFactory
    {
        public SmsNotificationSenderAbstractFactory(TokenFactory factory) : base(factory)
        { }

        public SmsNotificationSenderAbstractFactory() : base(new FourDigitsCodeFactory())
        { }
    }

    public class GuidTokenFactory : TokenFactory
    {
        public override string CreateToken()
        {
            return Guid.NewGuid().ToString();
        }
    }

    public class FourDigitsCodeFactory : TokenFactory
    {
        private static readonly Random Random = new Random();

        public override string CreateToken()
        {
            return Random.Next(1000, 9999).ToString();
        }
    }
}
