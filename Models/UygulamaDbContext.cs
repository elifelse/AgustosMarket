using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AgustosMarket.Models
{
    public class UygulamaDbContext : DbContext
    {
        public UygulamaDbContext(DbContextOptions<UygulamaDbContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Kategori>().HasData(
                new Kategori() { Id = 1, KategoriAd = "Temizlik" },
                new Kategori() { Id = 2, KategoriAd = "Meyve/Sebze" }
            );

            modelBuilder.Entity<Urun>().HasData(
                    new Urun() { Id = 1, KategoriId = 1, UrunAd = "Deterjan", BirimFiyat = 19.90m },
                    new Urun() { Id = 2, KategoriId = 1, UrunAd = "Sabun", BirimFiyat = 9.90m },
                    new Urun() { Id = 3, KategoriId = 1, UrunAd = "Temizlik Bezi", BirimFiyat = 9.90m },
                    new Urun() { Id = 4, KategoriId = 2, UrunAd = "Elma", BirimFiyat = 6.90m },
                    new Urun() { Id = 5, KategoriId = 2, UrunAd = "Karpuz", BirimFiyat = 5.00m },
                    new Urun() { Id = 6, KategoriId = 2, UrunAd = "Çilek", BirimFiyat = 15.40m }
                );
        }

        public DbSet<Kategori> Kategoriler { get; set; }
        public DbSet<Urun> Urunler { get; set; }
    }
}
