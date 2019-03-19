using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicKapperszaak
{
   public  class CadeauKaart
    {
        public string bestemd { get; set; }
        public decimal bedrag { get; set; }
        public Klant Klant { get; set; }

        public CadeauKaart(string Bestemd, decimal Bedrag, Klant klant)
        {
            Klant = klant; 
            bestemd = Bestemd;
            bedrag = Bedrag;
        }
    }
}
