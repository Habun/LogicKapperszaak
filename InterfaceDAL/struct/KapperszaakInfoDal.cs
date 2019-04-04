using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceDAL
{
   public struct KapperszaakInfoDal
    {
        public int kapperszaakid { get; }
        public string naam { get; }

        public KapperszaakInfoDal(int KapperszaakId, string Naam)
        {
            kapperszaakid = KapperszaakId;
            naam = Naam;
        }
    }
}
