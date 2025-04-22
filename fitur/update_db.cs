using System;
using Npgsql;

namespace koneksi_database.fitur
{
    class UpdateData
    {
        public static void Execute()
        {
            using (var connection = Koneksi.GetConnection())
            {
                Console.Write("ID Barang yang ingin diupdate: ");
                string id = Console.ReadLine();
                Console.Write("Stok Baru: ");
                int stok = int.Parse(Console.ReadLine());

                string updateSql = "UPDATE jualan SET stok_barang = @stok_barang WHERE id_barang = @id_barang";
                var command = new NpgsqlCommand(updateSql, connection);
                command.Parameters.AddWithValue("@stok_barang", stok);
                command.Parameters.AddWithValue("@id_barang", id);

                try
                {
                    connection.Open();
                    int result = command.ExecuteNonQuery();
                    Console.WriteLine($"Updated {result} row(s).");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error: {ex.Message}");
                }
            }
        }
    }
}
