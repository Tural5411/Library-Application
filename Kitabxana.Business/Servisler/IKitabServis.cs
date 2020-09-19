using Kitabxana.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kitabxana.Business.Servisler
{
    public interface IKitabServis:IServisSablon<Kitab>
    {
        Kitab IdDeyerineGoreGetir(int id);
    }
}
