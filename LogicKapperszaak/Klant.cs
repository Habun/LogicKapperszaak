using System;
using InterfaceUI;
using InterfaceDAL;
using FactoryDAL;

namespace LogicKapperszaak
{
    public class Klant : IKlantUi
    {
        public string Naam { get;}
        public int Telefoonnummer { get;}
        public string Emailadres { get;}

        IKlantDAL klantDAL = DatabaseFactory.KlantDAL();

        public Klant()
        {
        }

        public Klant(string naam, int telefoonnummer, string emailadres)
        {
            Naam = naam;
            Telefoonnummer = telefoonnummer;
            Emailadres = emailadres;
        }

        public void CadeauKaartReserveren(ICadeauKaartUi cadeauKaart, IKlantUi klant)
        {
             KlantInfoDal klantinfo = new KlantInfoDal(klant.Naam, klant.Telefoonnummer, klant.Emailadres);
             CadeauKaartInfoDal cadeaukaartinfo = new CadeauKaartInfoDal(cadeauKaart.Bestemd, cadeauKaart.Bedrag, klantinfo);

             klantDAL.CadeauKaartReserveren(cadeaukaartinfo);
        }

        public void AfspraakReserveren()
        {
            throw new NotImplementedException();
        }
    }
}
