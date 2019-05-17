using System;
using System.Collections.Generic;
using InterfaceUI;

namespace LogicKapperszaak
{
    public class Afspraak
    {
        public int AfspraakId { get; set; }
        public string Opmerkingen { get; set; }
        public DateTime datetime { get; set; }
        public Klant klant { get; set; }

        public Afspraak(int afspraakId, string opmerking, DateTime dateTime, Klant klantAF)
        {
            AfspraakId = afspraakId;
            klant = klantAF;
            Opmerkingen = opmerking;
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
