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
        public abstract IMailTemplate CreateTemplate(IMailProperties properties); //Can be parametriced with type if needed
    }

    public class AppMailFactory : MailTemplateFactoryMethod
    {
        public override IMailTemplate CreateTemplate(IMailProperties properties)
        {
            return new WelcomeAppMailTemplate(properties);
        }
    }

    public class WebMailFactory : MailTemplateFactoryMethod
    {
        public override IMailTemplate CreateTemplate(IMailProperties properties)
        {
            return new WelcomeWebMailTemplate(properties);
        }
    }
}
