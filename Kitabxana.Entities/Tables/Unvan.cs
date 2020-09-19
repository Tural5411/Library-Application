using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Kitabxana.DataAccess.Interface;

namespace Kitabxana.Entities
{
    public class Unvan : IEntity
    {
        public int Id { get; set; }
        public int IstifadeciId { get; set; }

        public string Seher { get; set; }
        public string Rayon { get; set; }
        public string Menteqe { get; set; }
        public string Metro { get; set; }
        public string Adres { get; set; }
        public string Aciqlama { get; set; }

        public virtual Istifadeci Istifadeci { get; set; }

    }
}
