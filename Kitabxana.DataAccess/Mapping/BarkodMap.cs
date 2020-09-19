using Kitabxana.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kitabxana.DataAccess.Mapping
{
    public class BarkodMap:EntityTypeConfiguration<Barkod>
    {
        public BarkodMap()
        {
            this.HasKey(x => x.Id);
            this.Property(x => x.Id).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            this.Property(x => x.Otaq).HasMaxLength(30);
            this.Property(x => x.Barkodu).HasMaxLength(12);
            this.Property(x => x.Ref).HasMaxLength(30);
            this.Property(x => x.Sira).HasMaxLength(30);
            this.Property(x => x.Siyirme).HasMaxLength(30);
            this.Property(x => x.Aciqlama).HasMaxLength(200);

            this.ToTable("Barkodlar");
            this.Property(c => c.Id).HasColumnName("Id");
            this.Property(c => c.Deyerlendirme).HasColumnName("Deyerlendirme");
            this.Property(c => c.Barkodu).HasColumnName("Barkodu");
            this.Property(c => c.Aciqlama).HasColumnName("Aciqlama");
            this.Property(c => c.KitabId).HasColumnName("KitabId");
            this.Property(c => c.Otaq).HasColumnName("Otaq");
            this.Property(c => c.Ref).HasColumnName("Ref");
            this.Property(c => c.Sira).HasColumnName("Sira");
            this.Property(c => c.Siyirme).HasColumnName("Siyirme");
        }
    }
}
