using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Kitabxana.DataAccess.Interface;

namespace Kitabxana.Entities
{
    public class KitabHereket:IEntity
    {
        public int Id { get; set; }
        public int KitabId { get; set; }
        public int IstifadeciId { get; set; }
        public int BarkodId { get; set; }
        public bool TeslimEdildi { get; set; }
        public DateTime VerilmeTarixi { get; set; }
        public int VerilmeMuddeti { get; set; }
        public DateTime? TeslimTarixi { get; set; }
        public int DeyerlendirmeKitab { get; set; }
        public int DeyerlendirmeZaman { get; set; }
        public int DeyerlendirmeUmumi { get; set; }
        public string Aciqlama { get; set; }
        public virtual Kitab Kitab { get; set; }
        public virtual Istifadeci Istifadeci { get; set; }
        public virtual Barkod Barkod { get; set; }
    }
}
