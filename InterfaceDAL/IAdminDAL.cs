﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceDAL
{
   public interface IAdminDAL
   {
       List<KapperszaakInfoDal> AlleKappersZakenOphalen();
   }
}
