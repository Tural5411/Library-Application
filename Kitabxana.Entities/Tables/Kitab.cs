using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Kitabxana.DataAccess.Interface;

namespace Kitabxana.Entities
{
    public class Kitab:IEntity
    {
        public int Id { get; set; }
        public bool Veziyyet { get; set; }
        public string KitabAdi { get; set; }
        public bool KirayeVerilebiler { get; set; }
        public string KitabKodu { get; set; }
        public string ISBN { get; set; }
        public int Nesrili { get; set; }
        public int NesrSayi { get; set; }
        public int SehifeSayi { get; set; }
        public int CildSayi { get; set; }
        public int MuellifId { get; set; }
        public string Nesriyyat { get; set; }
        public string Novu { get; set; }
        public string Demirbasno { get; set; }
        public string Aciqlama { get; set; }

        public virtual Muellif Muellifs { get; set; }
        public virtual ICollection<Barkod> Barkods { get; set; }
        public virtual ICollection<KitabHereket> KitabHereketler { get; set; }

    }
}
