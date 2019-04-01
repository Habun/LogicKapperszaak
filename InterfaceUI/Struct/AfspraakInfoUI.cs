using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceUI
{
    public struct AfspraakInfoUI
    {
        public string opmerkingen { get;}
        public DateTime datetime { get;}
        public KlantInfoUI klantInfoUI { get;}

        public AfspraakInfoUI(string Opmerking, DateTime dateTime, KlantInfoUI klantinfoAF)
        {
            klantInfoUI = klantinfoAF;
            opmerkingen = Opmerking;
            datetime = dateTime;
        }
    }
}
