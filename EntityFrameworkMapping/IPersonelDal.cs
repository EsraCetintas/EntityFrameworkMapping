﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkMapping
{
   public interface IPersonelDal
    {
        List<Personel> GetAll();
    }
}
