namespace Case.Models.DataModel
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class CaseDb : DbContext
    {
        public CaseDb()
            : base("name=CaseDb")
        {
        }

        public virtual DbSet<EnmDepartman> EnmDepartmen { get; set; }
        public virtual DbSet<EnmUnvan> EnmUnvans { get; set; }
        public virtual DbSet<Personel> Personels { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<EnmDepartman>()
                .Property(e => e.DepartmantName)
                .IsUnicode(false);

            modelBuilder.Entity<EnmUnvan>()
                .Property(e => e.UnvanAd)
                .IsUnicode(false);

            modelBuilder.Entity<Personel>()
                .Property(e => e.Ad)
                .IsUnicode(false);

            modelBuilder.Entity<Personel>()
                .Property(e => e.Soyad)
                .IsUnicode(false);

            modelBuilder.Entity<Personel>()
                .Property(e => e.Email)
                .IsUnicode(false);

            modelBuilder.Entity<Personel>()
                .Property(e => e.EvTelefon)
                .IsUnicode(false);

            modelBuilder.Entity<Personel>()
                .Property(e => e.CepTelefonu)
                .IsUnicode(false);

            modelBuilder.Entity<Personel>()
                .Property(e => e.Cinsiyet)
                .IsUnicode(false);
        }
    }
}
