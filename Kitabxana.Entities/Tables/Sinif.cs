using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Kitabxana.DataAccess.Interface;

namespace Kitabxana.Entities
{
    public class Sinif : IEntity
    {
        public int Id { get; set; }
        public string MektebNovu { get; set; }
        public string Sinifi { get; set; }
        public string Sobe { get; set; }
        public string Bolumu { get; set; }
        public string Aciqlama { get; set; }
        public ICollection<Istifadeci> Istifadeciler { get; set; }


    }
}
