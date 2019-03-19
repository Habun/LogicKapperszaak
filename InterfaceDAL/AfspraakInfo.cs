using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceDAL
{
   public struct AfspraakInfo
    {
        public string opmerkingen { get; private set; }
        public DateTime datetime { get; private set; }
        public KlantInfo klantinfo { get; private set; }

        public AfspraakInfo(string Opmerking, DateTime dateTime, KlantInfo klantinfoAF)
        {
            klantinfo = klantinfoAF;
            opmerkingen = Opmerking;
            datetime = dateTime;
        }
    }
}
