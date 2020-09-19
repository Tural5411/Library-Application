using Kitabxana.DataAccess.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kitabxana.Entities
{
    public class Barkod:IEntity
    {
        public int Id { get; set; }
        public int KitabId { get; set; }
        public string Barkodu { get; set; }
        public int Deyerlendirme { get; set; }
        public string Otaq { get; set; }
        public string Ref { get; set; }
        public string Siyirme { get; set; }
        public string Sira { get; set; }
        public string Aciqlama { get; set; }
        public virtual Kitab Kitab { get; set; }
        public virtual ICollection<KitabHereket> KitabHereketleri { get; set; }

    }
}
