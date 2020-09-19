using Kitabxana.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kitabxana.DataAccess.Mapping
{
   public class MuellifMap:EntityTypeConfiguration<Muellif>
    {
        public MuellifMap()
        {
            this.HasKey(x => x.Id);
            this.Property(x => x.Id).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            this.Property(x => x.Aciqlama).HasMaxLength(200);

            this.ToTable("Muellifler");
            this.Property(x => x.Id).HasColumnName("Id");
            this.Property(x => x.DogumTarixi).HasColumnName("DogumTarixi");
            this.Property(x => x.Aciqlama).HasColumnName("Aciqlama");
            this.Property(x => x.Adi).HasColumnName("Adi");
            this.Property(x => x.Soyadi).HasColumnName("Soyadi");
        }
    }
}
