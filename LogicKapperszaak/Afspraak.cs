using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicKapperszaak
{
    public class Afspraak
    {
        public string opmerkingen { get; set; }
        public DateTime datetime { get; set; }
        public Klant klant { get; set; } 

        public Afspraak(string Opmerking, DateTime dateTime, Klant KlantAF)
        {
            klant = KlantAF;
            opmerkingen = Opmerking;
            datetime = dateTime;
        }

        public void BehandelingToevoegenAanAfspraak(Behandeling behandeling)
        {

        }
    }
}
