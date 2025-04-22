using System;

public class delete_db
{
	public delete()
	{
        string connectionString = "Host=localhost;Port=5432;Username=postgres;Password=a.1056.A;Database=PBO;";
        NpgsqlConnection connection = new NpgsqlConnection(connectionString);

        string deleteSql = "DELETE FROM jualan WHERE id_barang = @id_barang";
        NpgsqlCommand deleteCommand = new NpgsqlCommand(deleteSql, connection);

        Console.Write("Masukkan ID Barang");
        int id_barang = Console.ReadLine();
        deleteCommand.Parameters.AddWithValue("@id_barang", id_barang);

        try
        {
            connection.Open();
            int rowsAffected = deleteCommand.ExecuteNonQuery();
            Console.WriteLine($"Deleted {rowsAffected} row(s)!");
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
