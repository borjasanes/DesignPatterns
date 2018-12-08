
using System;
using Creational.Factory.Models;

namespace Creational.Factory.Simple
{
    /// <summary>
    /// Encapsulate the class instantiation in one place
    /// 
    /// Violates OPEN CLOSE principle when adding more types.
    /// </summary>
    public static class MailTemplateFactory
    {
        public static IMailTemplate CreateTemplate(MailType mailType, IMailProperties properties)
        {
            switch (mailType)
            {
                case MailType.Welcome:
                    return new WelcomeAppMailTemplate(properties);
                case MailType.Goodby:
                    return new GoodbyMailTemplate(properties);
                default:
                    return null;
            }
        }
    }
}
