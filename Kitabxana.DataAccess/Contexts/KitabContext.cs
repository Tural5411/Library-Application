using Kitabxana.DataAccess.Mapping;
using Kitabxana.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Kitabxana.DataAccess.Contexts
{
    public class KitabContext : DbContext
    {
        public KitabContext() : base("name=LibraryDB")
        {
            //this.Configuration.ProxyCreationEnabled = false;
        }
        public DbSet<Kitab> Kitablar { get; set; }
        public DbSet<Barkod> Barkodlar { get; set; }
        public DbSet<Muellif> Muellifler { get; set; }
        public DbSet<Istifadeci> Istifadeciler { get; set; }
        public DbSet<Telefon> Telefonlar { get; set; }
        public DbSet<Unvan> Unvanlar { get; set; }
        public DbSet<KitabHereket> KitabHereketler { get; set; }
        public DbSet<Base> Baseler { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new KitabMap());
            modelBuilder.Configurations.Add(new IstifadeciMap());
            modelBuilder.Configurations.Add(new UnvanMap());
            modelBuilder.Configurations.Add(new TelefonMap());
            modelBuilder.Configurations.Add(new KitabHereketMap());
            modelBuilder.Configurations.Add(new MuellifMap());
            modelBuilder.Configurations.Add(new SinifMap());
            modelBuilder.Configurations.Add(new BaseMap());
            modelBuilder.Configurations.Add(new BarkodMap());

            modelBuilder.Entity<Kitab>().HasRequired(x => x.Muellifs).WithMany(x => x.Kitabs)
                .HasForeignKey(x => x.MuellifId);
            modelBuilder.Entity<Barkod>().HasRequired(x => x.Kitab).WithMany(x => x.Barkods)
                .HasForeignKey(x => x.KitabId).WillCascadeOnDelete();
            modelBuilder.Entity<KitabHereket>().HasRequired(x => x.Kitab).WithMany(x => x.KitabHereketler)
                .HasForeignKey(x => x.KitabId);
            modelBuilder.Entity<Istifadeci>().HasRequired(x => x.Sinif).WithMany(x => x.Istifadeciler)
                .HasForeignKey(x => x.SinifId);
            modelBuilder.Entity<Telefon>().HasRequired(x => x.Istifadeci).WithMany(x => x.Telefonlar)
                .HasForeignKey(x => x.IstifadeciId);
            modelBuilder.Entity<Unvan>().HasRequired(x => x.Istifadeci).WithMany(x => x.Unvanlar)
                .HasForeignKey(x => x.IstifadeciId);
            modelBuilder.Entity<KitabHereket>().HasRequired(x => x.Istifadeci).WithMany(x => x.KitabHereketler)
                .HasForeignKey(x => x.IstifadeciId);
            modelBuilder.Entity<KitabHereket>().HasRequired(x => x.Barkod).WithMany(x => x.KitabHereketleri)
                .HasForeignKey(x => x.BarkodId).WillCascadeOnDelete(false);
        }
    }
}
