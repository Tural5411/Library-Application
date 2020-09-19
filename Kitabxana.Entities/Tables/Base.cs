using Kitabxana.DataAccess.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kitabxana.Entities
{
    public class Base : IEntity
    {
        public int Id { get; set; }
        public string Tanim { get; set; }
        public string Novu { get; set; }
        public string Aciqlama { get; set; }
    }
}
