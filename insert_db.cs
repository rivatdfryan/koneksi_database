using System;

public class insert_db
{
	public insert()
	{
        string connectionString = "Host=localhost;Port=5432;Username=postgres;Password=a.1056.A;Database=PBO;";
        NpgsqlConnection connection = new NpgsqlConnection(connectionString);
        string insertSql = "INSERT INTO jualan (id_barang,nama_barang,stok_barang,jenis_barang,harga_barang) VALUES (@id_barang,@nama_barang,@stok_barang,@jenis_barang,@harga_barang)";
        NpgsqlCommand insertCommand = new NpgsqlCommand(insertSql, connection);

        Console.Write("Masukkan id barang : ")
        string tambah_barang = Console.ReadLine();
        Console.Write("Masukkan Nama Barang : ")
        string nama_barang = Console.ReadLine();
        Console.Write("Masukkan Stok Barang : ")
        string stok_barang = Console.ReadLine();
        Console.Write("Masukkan Jenis Barang : ")
        int jenis_barang = Console.ReadLine();
        Console.Write("Masukkan Harga Barang")
        int harga_barang = Console.ReadLine();

        insertCommand.Parameters.AddWithValue("@id_barang", tambah_barang);
        insertCommand.Parameters.AddWithValue("@nama_barang", nama_barang);
        insertCommand.Parameters.AddWithValue("@stok_barang", stok_barang);
        insertCommand.Parameters.AddWithValue("@jenis_barang", jenis_barang);
        insertCommand.Parameters.AddWithValue("@harga_barang", harga_barang);
        try
        {
            connection.Open();
            int rowsAffected = insertCommand.ExecuteNonQuery();
            Console.WriteLine($"Inserted {rowsAffected} row(s)!");
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
