using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceDAL
{
    public struct CadeauKaartInfo
    {
        public string bestemd { get; private set; }
        public decimal bedrag { get; private set; }
        public KlantInfo klantinfo { get; private set; }
        
        public CadeauKaartInfo(string Bestemd, decimal Bedrag, KlantInfo klantinfoCK)
        {
            klantinfo = klantinfoCK;
            bestemd = Bestemd;
            bedrag = Bedrag;
        }
    }
}
