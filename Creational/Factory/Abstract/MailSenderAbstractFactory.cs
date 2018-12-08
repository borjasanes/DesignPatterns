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
        public abstract IMailTemplate CreateMailTemplate(IMailProperties properties, MailType type);
        public abstract ISmsTemplate CreateSmsTemplate(ISmsProperties properties);
    }

    public class NotificationSenderAbstractFactory
    {
        private readonly TemplateFactory _templateFactory;

        public NotificationSenderAbstractFactory(TemplateFactory templateFactory)
        {
            _templateFactory = templateFactory;
        }

        public IMailTemplate SendMailNotification(IMailProperties properties, MailType type)
        {
            return _templateFactory.CreateMailTemplate(properties, type);
        }

        public ISmsTemplate SendSmsNotification(ISmsProperties properties)
        {
            return _templateFactory.CreateSmsTemplate(properties);
        }
    }

    public class CustomerNotificationSender : NotificationSenderAbstractFactory
    {
        public CustomerNotificationSender(TemplateFactory factory) : base(factory)
        { }

        public CustomerNotificationSender() : base(new CustomerTemplateFactory())
        { }
    }

    public class EmployeeNotificationSender : NotificationSenderAbstractFactory
    {
        public EmployeeNotificationSender(TemplateFactory factory) : base(factory)
        { }

        public EmployeeNotificationSender() : base(new EmployeeTemplateFactory())
        { }
    }

    public class CustomerTemplateFactory : TemplateFactory
    {
        public override IMailTemplate CreateMailTemplate(IMailProperties properties, MailType type)
        {
            switch (type)
            {
                case MailType.Welcome:
                    return new WelcomeCustomerMailTemplate(properties);
                case MailType.Goodby:
                    return null;
                default:
                    return null;
            }
        }

        public override ISmsTemplate CreateSmsTemplate(ISmsProperties properties)
        {
            return new WelcomeCustomerSmsTemplate(properties);
        }
    }

    public class EmployeeTemplateFactory : TemplateFactory
    {
        public override IMailTemplate CreateMailTemplate(IMailProperties properties, MailType type)
        {
            switch (type)
            {
                case MailType.Welcome:
                    return new WelcomeEmployeeMailTemplate(properties);
                case MailType.Goodby:
                    return null;
                default:
                    return null;
            }
        }

        public override ISmsTemplate CreateSmsTemplate(ISmsProperties properties)
        {
            return new WelcomeEmployeeSmsTemplate(properties);
        }
    }
}
