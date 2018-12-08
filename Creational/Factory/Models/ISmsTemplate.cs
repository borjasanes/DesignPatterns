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

    public class WelcomeCustomerSmsTemplate : ISmsTemplate
    {

        public WelcomeCustomerSmsTemplate(ISmsProperties properties)
        {
            PhoneNumber = properties.PhoneNumber;
        }

        public string PhoneNumber { get; set; }
        public string Body => $"Welcome customer {PhoneNumber}";
    }

    public class WelcomeEmployeeSmsTemplate : ISmsTemplate
    {

        public WelcomeEmployeeSmsTemplate(ISmsProperties properties)
        {
            PhoneNumber = properties.PhoneNumber;
        }

        public string PhoneNumber { get; set; }
        public string Body => $"Welcome employee {PhoneNumber}";
    }
}
