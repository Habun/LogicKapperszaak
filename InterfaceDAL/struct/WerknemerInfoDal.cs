﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceDAL
{
    public struct WerknemerInfoDal
    {
        public string Naam { get; }

        public WerknemerInfoDal(string naam)
        {
            Naam = naam;
        }
    }
}
