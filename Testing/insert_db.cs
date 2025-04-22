using System;
using Npgsql;

namespace koneksi_database.Testing
{
    class InsertData
    {
        public static void Execute()
        {
            using (var connection = Koneksi.GetConnection())
            {
                string insertSql = "INSERT INTO jualan (id_barang,nama_barang,stok_barang,jenis_barang,harga_barang) " +
                                   "VALUES (@id_barang,@nama_barang,@stok_barang,@jenis_barang,@harga_barang)";
                var command = new NpgsqlCommand(insertSql, connection);

                Console.Write("ID Barang: ");
                string id = Console.ReadLine();
                Console.Write("Nama Barang: ");
                string nama = Console.ReadLine();
                Console.Write("Stok Barang: ");
                int stok = int.Parse(Console.ReadLine());
                Console.Write("Jenis Barang: ");
                string jenis = Console.ReadLine();
                Console.Write("Harga Barang: ");
                int harga = int.Parse(Console.ReadLine());

                command.Parameters.AddWithValue("@id_barang", id);
                command.Parameters.AddWithValue("@nama_barang", nama);
                command.Parameters.AddWithValue("@stok_barang", stok);
                command.Parameters.AddWithValue("@jenis_barang", jenis);
                command.Parameters.AddWithValue("@harga_barang", harga);

                try
                {
                    connection.Open();
                    int result = command.ExecuteNonQuery();
                    Console.WriteLine($"Barang {nama} Berhasil ditambahkan");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error: {ex.Message}");
                }
            }
        }
    }
}
