using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceUI
{
   public struct CadeauKaartInfoUI
    {
        public string bestemd { get; private set; }
        public decimal bedrag { get; private set; }
        public KlantInfoUI klantinfo { get; private set; }

        public CadeauKaartInfoUI(string Bestemd, decimal Bedrag, KlantInfoUI klantinfoCK)
        {
            klantinfo = klantinfoCK;
            bestemd = Bestemd;
            bedrag = Bedrag;
        }
    }
}
