using System;
using System.Collections.Generic;
using System.Linq;
using FactoryDAL;
using InterfaceDAL;
using InterfaceUI;

namespace LogicKapperszaak
{
    public class Afspraak : IAfspraakUi
    {
        public int AfspraakId { get; }
        public string Opmerkingen { get;}
        public DateTime Datetime { get; }
        public List<IBehandelingUi> GekozenBehandelingenVoorAfspraak { get; } = new List<IBehandelingUi>();

        private IKlantUi _klantUi;

        private IAfspraakDAL afspraakDal = DatabaseFactory.AfspraakDal();

        public Afspraak(int afspraakId, string opmerking, DateTime dateTime, IKlantUi klantUi)
        {
            AfspraakId = afspraakId;
            Opmerkingen = opmerking;
            Datetime = dateTime;
            _klantUi = klantUi;
        }

        public Afspraak()
        {
        }

        public void BehandelingToevoegenAanAfspraak(IBehandelingUi behandeling, int afspraakId)
        {
            BehandelingInfoDal behandelinginfoDal = new BehandelingInfoDal(behandeling.Id, behandeling.Omschrijving, behandeling.Bedrag);

            afspraakDal.VoegBehandelingToeAanAfspraak(behandelinginfoDal, afspraakId);
        }
        public void BehandelingVerwijderenBijAfspraak(int behandelingId)
        {
           afspraakDal.VerwijderBehandeling(behandelingId);
        }
        public decimal KostenVanBehandelingenOptellen()
        {
            AfspraakBehandelingenOphalen(AfspraakId);
            decimal totaalBedragBehandelingen = GekozenBehandelingenVoorAfspraak.Sum(b => b.Bedrag);

            return  totaalBedragBehandelingen;
        }

        public List<IBehandelingUi> AfspraakBehandelingenOphalen(int afspraakId)
        {
            foreach (var bhInfo in afspraakDal.GekozenBehandelingenOphalen(afspraakId))
            {
                IBehandelingUi behandelingUI = new Behandeling(bhInfo.Id, bhInfo.Omschrijving, bhInfo.Bedrag);
                GekozenBehandelingenVoorAfspraak.Add(behandelingUI);
            }
            return GekozenBehandelingenVoorAfspraak;
        }
    }
}
