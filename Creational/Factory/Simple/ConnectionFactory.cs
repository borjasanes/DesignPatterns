
namespace Creational.Factory.Simple
{
    /// <summary>
    /// Encapsulate the class instantiation in one place
    /// 
    /// Violates OPEN CLOSE principle when adding more types.
    /// </summary>
    public static class ConnectionFactory
    {
        public static string GetConnectionString(string country)
        {
            switch (country)
            {
                case "ES":
                    return "SpainDb";
                case "DK":
                    return "DenmarkDb";
                case "AT":
                    return "AustriaDb";
                default:
                    return null;
            }
        }
    }
}
