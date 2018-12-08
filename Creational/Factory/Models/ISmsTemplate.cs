namespace Creational.Factory.Models
{
    public interface ISmsProperties
    {
        string PhoneNumber { get; set; }
        string Name { get; set; }
    }

    public class SmsProperties : ISmsProperties
    {
        public string PhoneNumber { get; set; }
        public string Name { get; set; }
    }

    public interface ISmsTemplate
    {
        string PhoneNumber { get; set; }
        string Body { get; }
    }

    public class WelcomeAppSmsTemplate : ISmsTemplate
    {

        public WelcomeAppSmsTemplate(ISmsProperties properties)
        {
            PhoneNumber = properties.PhoneNumber;
        }

        public string PhoneNumber { get; set; }
        public string Body => $"Welcome app {PhoneNumber}";
    }

    public class WelcomeWebSmsTemplate : ISmsTemplate
    {

        public WelcomeWebSmsTemplate(ISmsProperties properties)
        {
            PhoneNumber = properties.PhoneNumber;
        }

        public string PhoneNumber { get; set; }
        public string Body => $"Welcome web {PhoneNumber}";
    }
}
