using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InterfaceUI;

namespace LogicKapperszaak
{
   public class CadeauKaart
    {
        public string bestemd { get; set; }
        public decimal bedrag { get; set; }
        public KlantInfoUI KlantInfo { get; set; }

        public CadeauKaart(string Bestemd, decimal Bedrag, KlantInfoUI klantInfoUI)
        {
            KlantInfo = klantInfoUI; 
            bestemd = Bestemd;
            bedrag = Bedrag;
        }

        public CadeauKaart()
        {

        }
    }
}
