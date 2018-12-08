using System;
using Creational.Factory.Models;

namespace Creational.Factory.Method
{
    /// <summary>
    /// Define an interface for creating an object
    /// but let subclasses decide which class to instantiate. 
    /// the Factory Method pattern uses inheritance
    /// and relies on a subclass to handle the desired object instantiation.
    /// </summary>
    public abstract class MailTemplateFactoryMethod
    {
        public abstract IMailTemplate CreateTemplate(IMailProperties properties, MailType type);
    }

    public class CustomerMailFactory : MailTemplateFactoryMethod
    {
        public override IMailTemplate CreateTemplate(IMailProperties properties, MailType type)
        {
            switch (type)
            {
                case MailType.Welcome:
                    return new WelcomeCustomerMailTemplate(properties);
                case MailType.Goodby:
                    return new GoodbyMailTemplate(properties);
                default:
                    return null;
            }
        }
    }

    public class EmployeeMailFactory : MailTemplateFactoryMethod
    {
        public override IMailTemplate CreateTemplate(IMailProperties properties, MailType type)
        {
            switch (type)
            {
                case MailType.Welcome:
                    return new WelcomeEmployeeMailTemplate(properties);
                default:
                    return null;
            }
        }
    }
}
