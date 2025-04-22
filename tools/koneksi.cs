using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;

namespace koneksi_database.tools
{
    class koneksi
    {
        static void Main()
        {
            string connectionString = "Host=localhost;Port=5432;Username=postgres;Password=a.1056.A;Database=PBO;";
            NpgsqlConnection connection = new NpgsqlConnection(connectionString);

            //try
            //{
            //    connection.Open();
            //    Console.WriteLine("Connected to PostgreSQL!");
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine($"Error: {ex.Message}");
            //}
            //finally
            //{
            //    connection.Close();
            //}

            //string insertSql = "INSERT INTO jualan (id_barang,nama_barang,stok_barang,jenis_barang,harga_barang) VALUES (@id_barang,@nama_barang,@stok_barang,@jenis_barang,@harga_barang)";
            //NpgsqlCommand insertCommand = new NpgsqlCommand(insertSql, connection);


            //insertCommand.Parameters.AddWithValue("@id_barang", "001");
            //insertCommand.Parameters.AddWithValue("@nama_barang", "tas");
            //insertCommand.Parameters.AddWithValue("@stok_barang", 23);
            //insertCommand.Parameters.AddWithValue("@jenis_barang", "perabotan");
            //insertCommand.Parameters.AddWithValue("@harga_barang", 30000);

            //try
            //{
            //    connection.Open();
            //    int rowsAffected = insertCommand.ExecuteNonQuery();
            //    Console.WriteLine($"Inserted {rowsAffected} row(s)!");
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine($"Error: {ex.Message}");
            //}
            //finally
            //{
            //    connection.Close();
            //}

            //string deleteSql = "DELETE FROM jualan WHERE id_barang = @id_barang";
            //NpgsqlCommand deleteCommand = new NpgsqlCommand(deleteSql, connection);

            //// Parameter

            //deleteCommand.Parameters.AddWithValue("@id_barang", "001");

            //try
            //{
            //    connection.Open();
            //    int rowsAffected = deleteCommand.ExecuteNonQuery();
            //    Console.WriteLine($"Deleted {rowsAffected} row(s)!");
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine($"Error: {ex.Message}");
            //}
            //finally
            //{
            //    connection.Close();
            //}

            string updateSql = "UPDATE jualan SET stok_barang = @stok_barang WHERE id_barang = @id_barang";
            NpgsqlCommand updateCommand = new NpgsqlCommand(updateSql, connection);

            // Parameters
            updateCommand.Parameters.AddWithValue("@stok_barang", 700);
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
}
