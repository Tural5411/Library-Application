using Kitabxana.DataAccess.Contexts;
using Kitabxana.DataAccess.Interface;
using Kitabxana.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Kitabxana.DataAccess.VeriErisim
{
    public class KitabDal:EntityAnaSablon<Kitab,KitabContext>,IKitabDal
    {

    }
}
