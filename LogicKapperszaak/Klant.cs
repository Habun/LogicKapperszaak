using System;
using InterfaceUI;
using InterfaceDAL;
using FactoryDAL;

namespace LogicKapperszaak
{
    public class Klant : IKlantUI
    {
        public string Naam { get; set; }
        public int Telefoonnummer { get; set; }
        public string Emailadres { get; set; }

        IKlantDAL klantDAL = DatabaseFactory.KlantDAL();

        public CadeauKaartInfoDal cadeaukaartinfo;

        public Klant()
        {
        }

        public Klant(string naam, int telefoonnummer, string emailadres)
        {
            Naam = naam;
            Telefoonnummer = telefoonnummer;
            Emailadres = emailadres;
        }

        public void CadeauKaartReserveren(KlantInfoUI klantinfoUi, CadeauKaartInfoUI cadeauKaartinfoUI)
        {
            KlantInfoDal klantinfo = new KlantInfoDal(klantinfoUi.Naam, klantinfoUi.Telefoonnummer, klantinfoUi.Emailadres);
            cadeaukaartinfo = new CadeauKaartInfoDal(cadeauKaartinfoUI.Bestemd, cadeauKaartinfoUI.Bedrag, klantinfo);

            klantDAL.CadeauKaartReserveren(cadeaukaartinfo);
        }

        public void AfspraakReserveren()
        {
            throw new NotImplementedException();
        }
    }
}
