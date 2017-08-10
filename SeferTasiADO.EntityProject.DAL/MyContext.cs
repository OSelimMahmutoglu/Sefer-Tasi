using SeferTasiADO.EntityProject.Model.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeferTasiADO.EntityProject.DAL
{
public partial class MyContext : DbContext
    {

        public MyContext()
            : base("name=MyContext")
        {
        }

        public virtual DbSet<Firmalar> Firmalar { get; set; }
        public virtual DbSet<GirisBilgisi> GirisBilgisi { get; set; }
        public virtual DbSet<Kategoriler> Kategoriler { get; set; }
        public virtual DbSet<Musteriler> Musteriler { get; set; }
        public virtual DbSet<Odemeler> Odemeler { get; set; }
        public virtual DbSet<Rol> Rol { get; set; }
        public virtual DbSet<SiparisDetay> SiparisDetay { get; set; }
        public virtual DbSet<Siparisler> Siparisler { get; set; }
        public virtual DbSet<UrunDetay> UrunDetay { get; set; }
        public virtual DbSet<Urunler> Urunler { get; set; }
        public virtual DbSet<Yoneticiler> Yoneticiler { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Firmalar>()
                .Property(e => e.FirmaAdi)
                .IsUnicode(false);

            modelBuilder.Entity<Firmalar>()
                .Property(e => e.Adres)
                .IsUnicode(false);

         
            modelBuilder.Entity<Firmalar>()
                .Property(e => e.Telefon)
                .IsUnicode(false);

            modelBuilder.Entity<Firmalar>()
                .HasMany(e => e.Siparisler)
                .WithRequired(e => e.Firmalar)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Firmalar>()
                .HasMany(e => e.UrunDetay)
                .WithRequired(e => e.Firmalar)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<GirisBilgisi>()
                .Property(e => e.KullaniciAdi)
                .IsUnicode(false);

            modelBuilder.Entity<GirisBilgisi>()
                .Property(e => e.Mail)
                .IsUnicode(false);

            modelBuilder.Entity<Musteriler>()
                .Property(e => e.Adi)
                .IsUnicode(false);

            modelBuilder.Entity<Musteriler>()
                .Property(e => e.SoyAdi)
                .IsUnicode(false);
            
            modelBuilder.Entity<Musteriler>()
                .Property(e => e.Adres)
                .IsUnicode(false);

            modelBuilder.Entity<Musteriler>()
                .Property(e => e.Telefon)
                .IsUnicode(false);

            modelBuilder.Entity<Musteriler>()
                .HasMany(e => e.Siparisler)
                .WithRequired(e => e.Musteriler)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Odemeler>()
                .HasMany(e => e.Siparisler)
                .WithRequired(e => e.Odemeler)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Rol>()
                .Property(e => e.Rol1)
                .IsUnicode(false);

            modelBuilder.Entity<SiparisDetay>()
                .Property(e => e.SepetFiyati)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Siparisler>()
                .HasMany(e => e.SiparisDetay)
                .WithRequired(e => e.Siparisler)
                .HasForeignKey(e => e.PF_SiparisId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<UrunDetay>()
                .Property(e => e.UrunFiyati)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Urunler>()
                .HasMany(e => e.SiparisDetay)
                .WithRequired(e => e.Urunler)
                .HasForeignKey(e => e.PF_UrunId)
                .WillCascadeOnDelete(false);

           

            modelBuilder.Entity<Urunler>()
                .HasMany(e => e.UrunDetay)
                .WithRequired(e => e.Urunler)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Yoneticiler>()
                .Property(e => e.Adi)
                .IsUnicode(false);

            modelBuilder.Entity<Yoneticiler>()
                .Property(e => e.SoyAdi)
                .IsUnicode(false);
        }
    }

}

