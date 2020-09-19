using Kitabxana.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kitabxana.DataAccess.Mapping
{
   public  class TelefonMap:EntityTypeConfiguration<Telefon>
    {
        public TelefonMap()
        {
            this.HasKey(x => x.Id);
            this.Property(x => x.Id).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            this.Property(x => x.AdiSoyadi).HasMaxLength(61);
            this.Property(x => x.Telefonu).HasMaxLength(15);
            this.Property(x => x.Mesafe).HasMaxLength(100);

            this.ToTable("Telefonlar");
            this.Property(x => x.Id).HasColumnName("Id");
            this.Property(x => x.AdiSoyadi).HasColumnName("AdiSoyadi");
            this.Property(x => x.IstifadeciId).HasColumnName("IstifadeciId");
            this.Property(x => x.Mesafe).HasColumnName("Mesafe");
            this.Property(x => x.Telefonu).HasColumnName("Telefonu");
            this.Property(x => x.Aciqlama).HasColumnName("Aciqlama");
        }
    }
}
