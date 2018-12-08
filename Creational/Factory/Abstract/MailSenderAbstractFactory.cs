using System;
using Creational.Factory.Method;
using Creational.Factory.Models;

namespace Creational.Factory.Abstract
{
    /// <summary>
    /// the Abstract Factory pattern, a class delegates the responsibility
    /// of object instantiation to another object via composition
    /// </summary>
    public abstract class TemplateFactory
    {
        public abstract IMailTemplate CreateMailTemplate(IMailProperties properties);
        public abstract ISmsTemplate CreateSmsTemplate(ISmsProperties properties);
    }

    public class NotificationSenderAbstractFactory
    {
        private readonly TemplateFactory _templateFactory;

        public NotificationSenderAbstractFactory(TemplateFactory templateFactory)
        {
            _templateFactory = templateFactory;
        }

        public IMailTemplate SendMailNotification(IMailProperties properties)
        {
            return _templateFactory.CreateMailTemplate(properties);
        }

        public ISmsTemplate SendSmsNotification(ISmsProperties properties)
        {
            return _templateFactory.CreateSmsTemplate(properties);
        }
    }

    public class AppNotificationSender : NotificationSenderAbstractFactory
    {
        public AppNotificationSender(TemplateFactory factory) : base(factory)
        { }

        public AppNotificationSender() : base(new WelcomeAppTemplateFactory())
        { }
    }

    public class WebNotificationSender : NotificationSenderAbstractFactory
    {
        public WebNotificationSender(TemplateFactory factory) : base(factory)
        { }

        public WebNotificationSender() : base(new WelcomeWebTemplateFactory())
        { }
    }

    public class WelcomeAppTemplateFactory : TemplateFactory
    {
        public override IMailTemplate CreateMailTemplate(IMailProperties properties)
        {
            return new WelcomeAppMailTemplate(properties);
        }

        public override ISmsTemplate CreateSmsTemplate(ISmsProperties properties)
        {
            return new WelcomeAppSmsTemplate(properties);
        }
    }

    public class WelcomeWebTemplateFactory : TemplateFactory
    {
        public override IMailTemplate CreateMailTemplate(IMailProperties properties)
        {
            return new WelcomeWebMailTemplate(properties);
        }

        public override ISmsTemplate CreateSmsTemplate(ISmsProperties properties)
        {
            return new WelcomeWebSmsTemplate(properties);
        }
    }
}
