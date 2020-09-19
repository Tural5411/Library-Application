using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Kitabxana.DataAccess.Interface;

namespace Kitabxana.Entities
{
   public class Telefon : IEntity
    {
        public int Id { get; set; }
        public int IstifadeciId { get; set; }
        public string AdiSoyadi { get; set; }
        public string Mesafe { get; set; }
        public string Telefonu { get; set; }
        public string Aciqlama { get; set; }
        public virtual Istifadeci Istifadeci { get; set; }
    }
}
