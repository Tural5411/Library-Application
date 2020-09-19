using Kitabxana.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kitabxana.Business.Servisler
{
    public interface IKitabHereketServis:IServisSablon<KitabHereket>
    {
        object EnCoxOxunan(int saylari);
        object EnCoxOxuyan(int saylari);

    }
}
