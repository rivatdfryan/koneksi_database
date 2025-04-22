using System;
using Npgsql;

namespace koneksi_database.tools
{
    class DeleteData
    {
        public static void Execute()
        {
            using (var connection = Koneksi.GetConnection())
            {
                Console.Write("ID Barang yang ingin dihapus: ");
                string id = Console.ReadLine();

                string deleteSql = "DELETE FROM jualan WHERE id_barang = @id_barang";
                var command = new NpgsqlCommand(deleteSql, connection);
                command.Parameters.AddWithValue("@id_barang", id);

                try
                {
                    connection.Open();
                    int result = command.ExecuteNonQuery();
                    Console.WriteLine($"Deleted {result} row(s).");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error: {ex.Message}");
                }
            }
        }
    }
}
