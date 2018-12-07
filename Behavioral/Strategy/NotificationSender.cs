using System;

namespace Behavioral.Strategy
{
    /// <summary>
    /// Define a family of algorithms, encapsulate each one,
    /// and make them interchangeable.
    /// </summary>
    public interface INotificationSender
    {
        string SendNotification(string target, string content);
    }

    public interface INotificationProvider
    {
        string Send(string target, string content);
    }

    public class NotificationSender : INotificationSender
    {
        private INotificationProvider _provider;

        public NotificationSender(INotificationProvider provider)
        {
            _provider = provider;
        }

        public string SendNotification(string target, string content)
        {
            return _provider.Send(target, content); //strategy
        }

        public void ChangeProvider(INotificationProvider provider)
        {
            _provider = provider;
        }
    }

    public class SmsProviderOne : INotificationProvider
    {
        public string Send(string target, string content)
        {
            throw new Exception("No signal");
        }
    }

    public class SmsProviderTwo : INotificationProvider
    {
        public string Send(string target, string content)
        {
            return $"Sms sended to:{target}";
        }
    }

}
