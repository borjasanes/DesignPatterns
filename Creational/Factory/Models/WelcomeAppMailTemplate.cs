namespace Creational.Factory.Models
{
    public class WelcomeAppMailTemplate : IMailTemplate
    {
        private readonly string _name;

        public WelcomeAppMailTemplate(IMailProperties properties)
        {
            To = properties.Email;
            _name = properties.Name;
        }

        public string To { get; set; }
        public string Body => $"Welcome app {_name}";
    }

    public class WelcomeWebMailTemplate : IMailTemplate
    {
        private readonly string _name;

        public WelcomeWebMailTemplate(IMailProperties properties)
        {
            To = properties.Email;
            _name = properties.Name;
        }

        public string To { get; set; }
        public string Body => $"Welcome web {_name}";
    }

}