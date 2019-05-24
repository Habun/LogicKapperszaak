using System;
using System.Collections.Generic;
using InterfaceUI;

namespace LogicKapperszaak
{
    public class Afspraak : IAfspraakUi
    {
        public string Opmerkingen { get;}
        public DateTime datetime { get; }
        public List<IBehandelingUi> behandelingen { get; } = new List<IBehandelingUi>();

        public IKlantUi _klantUi;


        public Afspraak(string opmerking, DateTime dateTime, IKlantUi klantUi)
        {
            Opmerkingen = opmerking;
            datetime = dateTime;
            _klantUi = klantUi;
        }

        public void BehandelingToevoegenAanAfspraak(IBehandelingUi behandeling)
        {

        }

        public void BehandelingVerwijderenBijAfspraak()
        {

        }
        public List<IBehandelingUi> AfspraakBehandelingenOphalen()
        {
            throw new NotImplementedException();
        }
    }
}
