using System;
using System.Linq;

namespace koneksi_database.fitur
{
    class TampilkanData
    {
        public static void Execute()
        {
            using var db = new AppDbContext();
            var list = db.Jualan.ToList();
            foreach (var item in list)
            {
                Console.WriteLine($"{item.id_barang} | {item.nama_barang} | Stok: {item.stok_barang} | Jenis: {item.jenis_barang} | Harga: {item.harga_barang}");
            }
        }
    }
}
