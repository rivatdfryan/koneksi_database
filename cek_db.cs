using Npgsql;
using System;

public class Cek_database
{
	public database()
	{
        string connectionString = "Host=localhost;Port=5432;Username=postgres;Password=a.1056.A;Database=PBO;";
        NpgsqlConnection connection = new NpgsqlConnection(connectionString);
        try
        {
            connection.Open();
            Console.WriteLine("Connected to PostgreSQL!");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }
        finally
        {
            connection.Close();
        }
    }
}
