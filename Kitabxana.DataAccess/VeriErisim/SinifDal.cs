﻿using Kitabxana.DataAccess.Contexts;
using Kitabxana.DataAccess.Interface;
using Kitabxana.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kitabxana.DataAccess.VeriErisim
{
    public class SinifDal:EntityAnaSablon<Sinif,KitabContext>,ISinifDal
    {
    }
}
