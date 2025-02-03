using Npgsql;

namespace Library
{
    internal class DataBase
    {
        private static readonly string connectionString = "Host=localhost;Port=5432;Database=Library;Username=postgres;Password=2928";
        private NpgsqlConnection conn;

        public DataBase()
        {
            conn = new NpgsqlConnection(connectionString);
        }

        public void openConnection()
        {
            if (conn.State == System.Data.ConnectionState.Closed)
            {
                conn.Open();
            }
        }
        public void closeConnection()
        {
            if (conn.State == System.Data.ConnectionState.Open)
            {
                conn.Close();
            }
        }

        public NpgsqlConnection getConnection()
        {
            return conn;
        }
    }
}
