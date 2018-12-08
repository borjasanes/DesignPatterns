namespace Creational.Factory.Models
{
    public interface IMailTemplate
    {
        string To { get; set; }
        string Body { get; }
    }
}