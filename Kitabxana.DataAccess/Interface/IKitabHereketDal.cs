using Kitabxana.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kitabxana.DataAccess.Interface
{
    public interface IKitabHereketDal:IEntitySablon<KitabHereket>
    {
        object EnCoxOxunan(int saylari);
        object EnCoxOxuyan(int saylari);
    }
}
