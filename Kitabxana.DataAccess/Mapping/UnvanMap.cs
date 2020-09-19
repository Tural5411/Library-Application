using Kitabxana.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kitabxana.DataAccess.Mapping
{
    public class UnvanMap:EntityTypeConfiguration<Unvan>
    {
        public UnvanMap()
        {
            this.HasKey(x => x.Id);
            this.Property(x => x.Id).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            this.Property(x => x.Aciqlama).HasMaxLength(200);
            this.Property(x => x.Adres).HasMaxLength(200);
            this.Property(x => x.Metro).HasMaxLength(30);
            this.Property(x => x.Rayon).HasMaxLength(30);
            this.Property(x => x.Seher).HasMaxLength(30);
            this.Property(x => x.Menteqe).HasMaxLength(30);

            this.ToTable("Unvanlar");
            this.Property(x => x.Id).HasColumnName("Id");
            this.Property(x => x.Adres).HasColumnName("Adres");
            this.Property(x => x.Aciqlama).HasColumnName("Aciqlama");
            this.Property(x => x.Seher).HasColumnName("Seher");
            this.Property(x => x.Rayon).HasColumnName("Rayon");
            this.Property(x => x.Metro).HasColumnName("Metro");
            this.Property(x => x.Menteqe).HasColumnName("Menteqe");
            this.Property(x => x.IstifadeciId).HasColumnName("IstifadeciId");

        }
    }
}
