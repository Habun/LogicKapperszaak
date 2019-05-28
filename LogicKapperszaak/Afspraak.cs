using System;
using System.Collections.Generic;
using InterfaceUI;

namespace LogicKapperszaak
{
    public class Afspraak : IAfspraakUi
    {
        public string Opmerkingen { get;}
        public DateTime datetime { get; }
        public List<Behandeling> behandelingen { get; set; } = new List<Behandeling>()
        {
            new Behandeling(1, "Scheren", 13),
            new Behandeling(3, "", 25)
        };
        public IKlantUi _klantUi;


        public Afspraak(string opmerking, DateTime dateTime, IKlantUi klantUi)
        {
            Opmerkingen = opmerking;
            datetime = dateTime;
            _klantUi = klantUi;
        }

        public Afspraak()
        {
        }

        public void BehandelingToevoegenAanAfspraak(IBehandelingUi behandeling)
        {

        }
        public void BehandelingVerwijderenBijAfspraak()
        {

        }

        public void KostenVanBehandelingenOptellen(Behandeling bh)
        {
            foreach (var bhbedrag in behandelingen)
            {
                decimal totaal = bhbedrag.Bedrag + bh.Bedrag;
            }
        }

        public List<IBehandelingUi> AfspraakBehandelingenOphalen()
        {
            throw new NotImplementedException();
        }

        public void KostenVanBehandelingenOptellen()
        {
            throw new NotImplementedException();
        }
    }
}
