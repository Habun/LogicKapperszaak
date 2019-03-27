using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceUI
{
    public struct AfspraakInfoUI
    {
        public string opmerkingen { get; private set; }
        public DateTime datetime { get; private set; }
        public KlantInfoUI klantInfoUI { get; private set; }

        public AfspraakInfoUI(string Opmerking, DateTime dateTime, KlantInfoUI klantinfoAF)
        {
            klantInfoUI = klantinfoAF;
            opmerkingen = Opmerking;
            datetime = dateTime;
        }
    }
}
