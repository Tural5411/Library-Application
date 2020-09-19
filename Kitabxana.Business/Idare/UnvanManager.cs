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
    public class UnvanManager:IdareSablonu<Unvan,UnvanDal,UnvanValidator>,IUnvanServis
    {   
    }
}
