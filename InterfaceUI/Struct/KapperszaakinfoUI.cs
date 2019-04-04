using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceUI
{
  public struct KapperszaakinfoUI
    {
        public int kapperszaakid { get; }
        public string naam { get; }

        public KapperszaakinfoUI(int KapperszaakId, string Naam)
        {
            kapperszaakid = KapperszaakId;
            naam = Naam;
        }
    }
}
