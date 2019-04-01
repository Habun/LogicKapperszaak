using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceDAL
{
    public struct CadeauKaartInfoDal
    {
        public string bestemd { get;}
        public decimal bedrag { get;}
        public KlantInfoDal klantinfo { get; }
        
        public CadeauKaartInfoDal(string Bestemd, decimal Bedrag, KlantInfoDal klantinfoCK)
        {
            klantinfo = klantinfoCK;
            bestemd = Bestemd;
            bedrag = Bedrag;
        }
    }
}
