using System.Dynamic;
using Creational.Factory.Models;

namespace Creational.Factory
{
    /// <summary>
    /// Define an interface for creating an object
    /// but let subclasses decide which class to instantiate. 
    /// </summary>
    public interface IMailFactory
    {
        IMailProperies CreateMailProperties(string name, string from, string to);
    }

    public interface IMailProperies
    {
        string From { get; set; }
        string To { get; set; }
        string MailId { get; set; }
    }

    public class WelcomeMailFactory : IMailFactory
    {
        private const string MailId = "WELCOME_ID";

        public IMailProperies CreateMailProperties(string name, string from, string to)
        {
            var body = $"Welcome {name}.";

            return new WelcomeMail
            {
                Body = body,
                From = from,
                To = to,
                MailId = MailId
            };
        }
    }

    public class WelcomeMail : IMailProperies
    {
        public string From { get; set; }
        public string To { get; set; }
        public string Body { get; set; }
        public string MailId { get; set; }
    }
}
