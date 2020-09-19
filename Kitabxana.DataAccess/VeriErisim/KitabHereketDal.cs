using Kitabxana.DataAccess.Contexts;
using Kitabxana.DataAccess.Interface;
using Kitabxana.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kitabxana.DataAccess.VeriErisim
{
    public class KitabHereketDal : EntityAnaSablon<KitabHereket, KitabContext>, IKitabHereketDal
    {
        public object EnCoxOxunan(int saylari)
        {
            return _context.Kitablar.GroupJoin(_context.KitabHereketler, x => x.Id, x => x.KitabId, (kitap, kitaphereket) => new
            {
                kitap,
                OxunmaSayi = kitaphereket.Count()
            }).OrderByDescending(x=>x.OxunmaSayi).Take(saylari).ToList();
        }

        public object EnCoxOxuyan(int saylari)
        {
            return _context.Istifadeciler.GroupJoin(_context.KitabHereketler, x => x.Id, x => x.IstifadeciId, (istfdci, kitaphereket) => new
            {
                istfdci,
                OxunmaSayi = kitaphereket.Count()
            }).OrderByDescending(x => x.OxunmaSayi).Take(saylari).ToList();
        }
    }
}
