using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace kütüphaneOtomasyonu.Entites
{
    public partial class ModelPersonelEntity : DbContext
    {
        public ModelPersonelEntity()
            : base("name=ModelPersonelEntity")
        {
        }

        public virtual DbSet<Birimler> Birimler { get; set; }
        public virtual DbSet<Personeller> Personeller { get; set; }
        public virtual DbSet<viewPersonelBirim> viewPersonelBirim { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Birimler>()
                .Property(e => e.Acıklama)
                .IsUnicode(false);

            modelBuilder.Entity<Personeller>()
                .Property(e => e.AdıSoyadı)
                .IsUnicode(false);

            modelBuilder.Entity<Personeller>()
                .Property(e => e.Telefon)
                .IsUnicode(false);

            modelBuilder.Entity<Personeller>()
                .Property(e => e.Adress)
                .IsUnicode(false);

            modelBuilder.Entity<Personeller>()
                .Property(e => e.Email)
                .IsUnicode(false);

            modelBuilder.Entity<viewPersonelBirim>()
                .Property(e => e.AdıSoyadı)
                .IsUnicode(false);

            modelBuilder.Entity<viewPersonelBirim>()
                .Property(e => e.Telefon)
                .IsUnicode(false);

            modelBuilder.Entity<viewPersonelBirim>()
                .Property(e => e.Adress)
                .IsUnicode(false);

            modelBuilder.Entity<viewPersonelBirim>()
                .Property(e => e.Email)
                .IsUnicode(false);
        }
    }
}
