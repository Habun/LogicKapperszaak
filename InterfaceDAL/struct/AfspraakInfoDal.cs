using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceDAL
{
   public struct AfspraakInfoDal
    {
        public string opmerkingen { get; private set; }
        public DateTime datetime { get; private set; }
        public KlantInfoDal klantinfo { get; private set; }

        public AfspraakInfoDal(string Opmerking, DateTime dateTime, KlantInfoDal klantinfoAF)
        {
            klantinfo = klantinfoAF;
            opmerkingen = Opmerking;
            datetime = dateTime;
        }
    }
}
