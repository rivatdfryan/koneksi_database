using Npgsql;

namespace koneksi_database.fitur
{
    class Koneksi
    {
        private static string connectionString = "Host=localhost;Port=5432;Username=postgres;Password=a.1056.A;Database=PBO;";

        public static NpgsqlConnection GetConnection()
        {
            return new NpgsqlConnection(connectionString);
        }
    }
}
