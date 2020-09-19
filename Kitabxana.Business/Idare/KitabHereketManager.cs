using Kitabxana.Business.Servisler;
using Kitabxana.Business.Tesdiqlemeler;
using Kitabxana.DataAccess.VeriErisim;
using Kitabxana.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kitabxana.Business.Idare
{
    public class KitabHereketManager : IdareSablonu<KitabHereket, KitabHereketDal, KitabHereketValidator>, IKitabHereketServis
    {
        public object EnCoxOxunan(int saylari)
        {
            return _dal.EnCoxOxunan(saylari);
        }

        public object EnCoxOxuyan(int saylari)
        {
            return _dal.EnCoxOxuyan(saylari);
        }
    }
}
