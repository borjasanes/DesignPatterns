namespace Creational.Factory
{
    public class SqlConnection
    {
        private readonly string _connectionString;

        public SqlConnection(string connectionString)
        {
            _connectionString = connectionString;
        }
    }
}