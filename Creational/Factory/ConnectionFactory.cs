
namespace Creational.Factory
{
    /// <summary>
    /// Encapsulate the class instantiation in one place
    /// 
    /// Violates OPEN CLOSE principle when adding more types.
    /// </summary>
    public static class ConnectionFactory
    {
        public static SqlConnection CreateSqlConnection(string country)
        {
            switch (country)
            {
                case "ES":
                    return new SqlConnection("SpainDb");
                case "DK":
                    return new SqlConnection("DenmarkDb");
                case "AT":
                    return new SqlConnection("AustriaDb");
                default:
                    return null;
            }
        }
    }
}
