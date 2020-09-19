using Kitabxana.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Core.EntityClient;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kitabxana.DataAccess.Mapping
{
    public class KitabMap : EntityTypeConfiguration<Kitab>
    {
        public KitabMap()
        {
            this.HasKey(c => c.Id);
            this.Property(c => c.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            this.Property(c => c.KitabKodu).HasMaxLength(12);
            this.Property(c => c.ISBN).HasMaxLength(20);
            this.Property(c => c.Demirbasno).HasMaxLength(20);
            this.Property(c => c.Novu).HasMaxLength(30);
            this.Property(c => c.Aciqlama).HasMaxLength(200);

            this.ToTable("Kitablar");
            this.Property(c => c.Id).HasColumnName("Id");
            this.Property(c => c.Veziyyet).HasColumnName("Veziyyet");
            this.Property(c => c.KitabAdi).HasColumnName("KitabAdi");
            this.Property(c => c.KirayeVerilebiler).HasColumnName("KirayeVerilebiler");
            this.Property(c => c.KitabKodu).HasColumnName("KitabKodu");
            this.Property(c => c.ISBN).HasColumnName("ISBN");
            this.Property(c => c.Nesrili).HasColumnName("Nesrili");
            this.Property(c => c.Nesriyyat).HasColumnName("Nesriyyat");
            this.Property(c => c.NesrSayi).HasColumnName("NesrSayi");
            this.Property(c => c.CildSayi).HasColumnName("CildSayi");
            this.Property(c => c.SehifeSayi).HasColumnName("SehifeSayi");
            this.Property(c => c.MuellifId).HasColumnName("MuellifId");
            this.Property(c => c.Novu).HasColumnName("Novu");
            this.Property(c => c.Demirbasno).HasColumnName("Demirbasno");
            this.Property(c => c.Aciqlama).HasColumnName("Aciqlama");

        }
    }
}
