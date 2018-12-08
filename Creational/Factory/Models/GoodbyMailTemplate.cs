namespace Creational.Factory.Models
{
    public class GoodbyMailTemplate : IMailTemplate
    {
        private readonly string _name;

        public GoodbyMailTemplate(IMailProperties properties)
        {
            To = properties.Email;
            _name = properties.Name;
        }

        public string To { get; set; }
        public string Name { get; set; }
        public string Body => $"Goodby {_name}";
    }
}