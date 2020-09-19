using Kitabxana.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Metadata.Edm;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kitabxana.DataAccess.Mapping
{
    public class KitabHereketMap:EntityTypeConfiguration<KitabHereket>
    {
        public KitabHereketMap()
        {
            this.HasKey(x => x.Id);
            this.Property(x => x.Id).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            this.Property(x => x.Aciqlama).HasMaxLength(200);

            this.ToTable("KitabHereketleri");
            this.Property(x => x.Id).HasColumnName("Id");
            this.Property(x => x.KitabId).HasColumnName("KitabId");
            this.Property(x => x.IstifadeciId).HasColumnName("IstifadeciId");
            this.Property(x => x.BarkodId).HasColumnName("BarkodId");
            this.Property(x => x.TeslimEdildi).HasColumnName("TeslimEdildi");
            this.Property(x => x.Aciqlama).HasColumnName("Aciqlama");
            this.Property(x => x.DeyerlendirmeKitab).HasColumnName("DeyerlendirmeKitab");
            this.Property(x => x.DeyerlendirmeUmumi).HasColumnName("DeyerlendirmeUmumi");
            this.Property(x => x.DeyerlendirmeZaman).HasColumnName("DeyerlendirmeZaman");
            this.Property(x => x.IstifadeciId).HasColumnName("IstifadeciId");
            this.Property(x => x.TeslimTarixi).HasColumnName("TeslimTarixi");
            this.Property(x => x.VerilmeTarixi).HasColumnName("VerilmeTarixi");
            this.Property(x => x.VerilmeMuddeti).HasColumnName("VerilmeMuddeti");
        }
    }
}
