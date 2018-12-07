namespace Creational.Factory.Method
{
    /// <summary>
    /// Define an interface for creating an object
    /// but let subclasses decide which class to instantiate. 
    /// </summary>
    public abstract class MailFactory
    {
        public IMailProperies BuildMailProperties(string name, string from, string to) //template method
        {
            var properies =  CreateMailProperties(from, to); //factory method

            properies.Body = ReplaceProperties(properies.Body, name);

            return properies;
        }

        protected abstract IMailProperies CreateMailProperties(string from, string to);

        private static string ReplaceProperties(string body, string name)
        {
            return body.Replace("{name}", name);
        }
    }

    public interface IMailProperies
    {
        string From { get; set; }
        string To { get; set; }
        string Body { get; set; }
    }

    public class WelcomeMailFactory : MailFactory
    {
        protected override IMailProperies CreateMailProperties(string from, string to)
        {
            return new WelcomeMail
            {
                Body = "Welcome {name}.",
                From = from,
                To = to
            };
        }
    }

    public class WelcomeMail : IMailProperies
    {
        public string From { get; set; }
        public string To { get; set; }
        public string Body { get; set; }
    }
}
