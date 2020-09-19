using Kitabxana.DataAccess.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kitabxana.Entities
{
    public class Istifadeci : IEntity
    {
        public int Id { get; set; }
        public bool Veziyyet { get; set; }
        public int SexsiyyetNo { get; set; }
        public int MektebNo { get; set; }
        public string Barkod { get; set; }
        public string Adi { get; set; }
        public string Soyadi { get; set; }
        public string Sektor { get; set; }
        public int SinifId { get; set; }
        public DateTime? QeydiyyatTarixi { get; set; }
        public string Aciqlama { get; set; }
        public virtual Sinif Sinif { get; set; }
        public virtual ICollection<Telefon> Telefonlar { get; set; }
        public virtual ICollection<Unvan> Unvanlar{ get; set; }
        public virtual ICollection<KitabHereket> KitabHereketler { get; set; }



    }
}
