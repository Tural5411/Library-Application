using Kitabxana.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kitabxana.DataAccess.Mapping
{
    public class IstifadeciMap : EntityTypeConfiguration<Istifadeci>
    {
        public IstifadeciMap()
        {
            this.HasKey(x => x.Id);
            this.Property(x => x.Id).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            this.Property(x => x.Barkod).HasMaxLength(20);
            this.Property(x => x.Adi).HasMaxLength(30);
            this.Property(x => x.Soyadi).HasMaxLength(30);
            this.Property(x => x.Sektor).HasMaxLength(40);
            this.Property(x => x.Aciqlama).HasMaxLength(200);

            this.ToTable("Istifadeciler");
            this.Property(x => x.Id).HasColumnName("Id");
            this.Property(x => x.SexsiyyetNo).HasColumnName("SexsiyyetNo");
            this.Property(x => x.Adi).HasColumnName("Adi");
            this.Property(x => x.Soyadi).HasColumnName("Soyadi");
            this.Property(x => x.Veziyyet).HasColumnName("Veziyyet");
            this.Property(x => x.Barkod).HasColumnName("Barkod");
            this.Property(x => x.SinifId).HasColumnName("SinifId");
            this.Property(x => x.MektebNo).HasColumnName("MektebNo");
            this.Property(x => x.QeydiyyatTarixi).HasColumnName("QeydiyyatTarixi");
            this.Property(x => x.Aciqlama).HasColumnName("Aciqlama");
        }
    }
}
