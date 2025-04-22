using System;

public class update_db
{
	public update()
	{
        string connectionString = "Host=localhost;Port=5432;Username=postgres;Password=a.1056.A;Database=PBO;";
        NpgsqlConnection connection = new NpgsqlConnection(connectionString);
        string updateSql = "UPDATE jualan SET stok_barang = @stok_barang WHERE id_barang = @id_barang";
        NpgsqlCommand updateCommand = new NpgsqlCommand(updateSql, connection);

        Console.Write("Masukkan Stok Barang : ")
        updateCommand.Parameters.AddWithValue("@stok_barang", 700);

        Console.Write("Masukkan ID Barang : ")
        updateCommand.Parameters.AddWithValue("@id_barang", "1");

        try
        {
            connection.Open();
            int rowsAffected = updateCommand.ExecuteNonQuery();
            Console.WriteLine($"Updated {rowsAffected} row(s)!");
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
