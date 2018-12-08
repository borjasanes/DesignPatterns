namespace Creational.Factory.Models
{
    public class WelcomeCustomerMailTemplate: IMailTemplate
    {
        private readonly string _name;

        public WelcomeCustomerMailTemplate(IMailProperties properties)
        {
            To = properties.Email;
            _name = properties.Name;
        }

        public string To { get; set; }
        public string Body => $"Welcome customer {_name}";
    }

    public class WelcomeEmployeeMailTemplate : IMailTemplate
    {
        private readonly string _name;

        public WelcomeEmployeeMailTemplate(IMailProperties properties)
        {
            To = properties.Email;
            _name = properties.Name;
        }

        public string To { get; set; }
        public string Body => $"Welcome employee {_name}";
    }

}