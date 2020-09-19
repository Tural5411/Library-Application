using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Kitabxana.DataAccess.Interface;
using System.Threading.Tasks;

namespace Kitabxana.Entities
{
    public class Muellif : IEntity
    {
        public int Id { get; set; }
        public string Adi { get; set; }
        public string Soyadi { get; set; }
        public int DogumTarixi { get; set; }
        public string  Aciqlama { get; set; }
        public virtual ICollection<Kitab> Kitabs { get; set; }
    }
}
