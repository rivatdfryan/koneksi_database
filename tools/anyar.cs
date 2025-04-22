using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;

namespace koneksi_database.tools
{
    class koneksi_baru
    {
        static string connectionString = "Host=localhost;Port=5432;Username=postgres;Password=a.1056.A;Database=PBO;";

        static NpgsqlConnection GetConnection()
        {
            return new NpgsqlConnection(connectionString);
        }

        static void InsertData()
        {
            using (var connection = GetConnection())
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
                    Console.WriteLine($"Inserted {result} row(s).");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error: {ex.Message}");
                }
            }
        }

        static void DeleteData()
        {
            using (var connection = GetConnection())
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

        static void UpdateData()
        {
            using (var connection = GetConnection())
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

        static void Main()
        {
            GetConnection();
            while (true)
            {
                Console.WriteLine("\n=== MENU CRUD ===");
                Console.WriteLine("1. Insert Data");
                Console.WriteLine("2. Delete Data");
                Console.WriteLine("3. Update Data");
                Console.WriteLine("4. Exit");
                Console.Write("Pilih menu (1-4): ");
                string pilihan = Console.ReadLine();

                switch (pilihan)
                {
                    case "1":
                        InsertData();
                        break;
                    case "2":
                        DeleteData();
                        break;
                    case "3":
                        UpdateData();
                        break;
                    case "4":
                        return;
                    default:
                        Console.WriteLine("Pilihan tidak valid.");
                        break;
                }
            }
        }
    }
}
