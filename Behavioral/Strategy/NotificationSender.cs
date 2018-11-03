using System;

namespace Behavioral.Strategy
{
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
            return _provider.Send(target, content);
        }

        public void ChangeProvider(INotificationProvider provider)
        {
            _provider = provider;
        }
    }

    public class MobileAppNotificationSender : NotificationSender
    {
        public MobileAppNotificationSender()
            : base(new SmsProviderOne())
        {

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
