using Kitabxana.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kitabxana.DataAccess.Mapping
{
    public class SinifMap:EntityTypeConfiguration<Sinif>
    {
        public SinifMap()
        {
            this.HasKey(x => x.Id);
            this.Property(x => x.Id).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            this.Property(x => x.MektebNovu).HasMaxLength(40);
            this.Property(x => x.Sinifi).HasMaxLength(40);
            this.Property(x => x.Sobe).HasMaxLength(40);
            this.Property(x => x.Aciqlama).HasMaxLength(200);
            this.Property(x => x.Bolumu).HasMaxLength(40);

            this.ToTable("Sinifler");
            this.Property(x => x.Id).HasColumnName("Id");
            this.Property(x => x.Bolumu).HasColumnName("Bolumu");
            this.Property(x => x.Aciqlama).HasColumnName("Aciqlama");
            this.Property(x => x.MektebNovu).HasColumnName("MektebNovu");
            this.Property(x => x.Sinifi).HasColumnName("Sinifi");
            this.Property(x => x.Sobe).HasColumnName("Sobe");


        }
    }
}
