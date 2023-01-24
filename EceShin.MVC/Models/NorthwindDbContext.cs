using Microsoft.EntityFrameworkCore;

namespace EceShin.MVC.Models
{
    public class NorthwindDbContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

            optionsBuilder.UseSqlServer("server=DESKTOP-O2V31BR; database=Northwind;trusted_connection=true;");

            base.OnConfiguring(optionsBuilder);
        }

        public DbSet<Urun> Urunler { get; set; }
        public DbSet<Kategori> Kategoriler { get; set; }
    }
}
