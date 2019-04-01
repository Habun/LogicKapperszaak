using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceUI
{
   public struct CadeauKaartInfoUI
    {
        public string bestemd { get;}
        public decimal bedrag { get;}
        public KlantInfoUI klantinfo { get;}

        public CadeauKaartInfoUI(string Bestemd, decimal Bedrag, KlantInfoUI klantinfoCK)
        {
            klantinfo = klantinfoCK;
            bestemd = Bestemd;
            bedrag = Bedrag;
        }
    }
}
