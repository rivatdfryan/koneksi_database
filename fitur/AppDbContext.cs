using Microsoft.EntityFrameworkCore;

namespace koneksi_database.fitur
{
    public class AppDbContext : DbContext
    {
        public DbSet<Jualan> Jualan { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("Host=localhost;Port=5432;Username=postgres;Password=a.1056.A;Database=PBO;");
        }
    }

    public class Jualan
    {
        public string id_barang { get; set; }
        public string nama_barang { get; set; }
        public int stok_barang { get; set; }
        public string jenis_barang { get; set; }
        public int harga_barang { get; set; }
    }
}
