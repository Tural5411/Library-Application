using Kitabxana.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Objects.DataClasses;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kitabxana.DataAccess.Mapping
{
    public class BaseMap:EntityTypeConfiguration<Base>
    {
        public BaseMap()
        {
            this.HasKey(x => x.Id);
            this.Property(x => x.Id).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            this.Property(x => x.Aciqlama).HasMaxLength(200);
            this.Property(x => x.Tanim).HasMaxLength(40);
            this.Property(x => x.Novu).HasMaxLength(20);


            this.ToTable("Tanimlar");
            this.Property(x => x.Id).HasColumnName("Id");
            this.Property(x => x.Aciqlama).HasColumnName("Aciqlama");
            this.Property(x => x.Tanim).HasColumnName("Tanim");
            this.Property(x => x.Novu).HasColumnName("Novu");
        }
    }
}
