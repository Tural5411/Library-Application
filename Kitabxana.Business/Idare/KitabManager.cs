using Kitabxana.Business.Servisler;
using Kitabxana.DataAccess.Interface;
using Kitabxana.DataAccess.VeriErisim;
using Kitabxana.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Kitabxana.Business.Idare
{
    public class KitabManager : IdareSablonu<Kitab, KitabDal,KitabValidator>, IKitabServis
    {
        public Kitab IdDeyerineGoreGetir(int id)
        {
            return this.Getir(x=>x.Id==id);
        }

        public override Kitab Sil(Kitab entity)
        {
            IKitabHereketServis kitabHereketServis = new KitabHereketManager();
            kitabHereketServis.Sil(x => x.KitabId == entity.Id);
            return base.Sil(entity);
        }
    }
}
