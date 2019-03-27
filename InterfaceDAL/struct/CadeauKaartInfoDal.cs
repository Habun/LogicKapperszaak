using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceDAL
{
    public struct CadeauKaartInfoDal
    {
        public string bestemd { get; private set; }
        public decimal bedrag { get; private set; }
        public KlantInfoDal klantinfo { get; private set; }
        
        public CadeauKaartInfoDal(string Bestemd, decimal Bedrag, KlantInfoDal klantinfoCK)
        {
            klantinfo = klantinfoCK;
            bestemd = Bestemd;
            bedrag = Bedrag;
        }
    }
}
