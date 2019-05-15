using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InterfaceDAL;
using InterfaceUI;

namespace LogicKapperszaak
{
    public class Afspraak
    {
        public int afspraakId { get; set; }
        public string opmerkingen { get; set; }
        public DateTime datetime { get; set; }
        public Klant klant { get; set; }

        public Afspraak(int AfspraakId, string Opmerking, DateTime dateTime, Klant KlantAF)
        {
            afspraakId = AfspraakId;
            klant = KlantAF;
            opmerkingen = Opmerking;
            datetime = dateTime;
        }

        public void BehandelingToevoegenAanAfspraak(int BehandelingsId)
        {

        }

        public void BehandelingVerwijderenBijAfspraak()
        {

        }
        public List<BehandelingsInfoUI> AfspraakBehandelingenOphalen()
        {
            throw new NotImplementedException();
        }

    }
}
