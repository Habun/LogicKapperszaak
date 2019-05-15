using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InterfaceUI;
using InterfaceDAL;
using FactoryDAL;

namespace LogicKapperszaak
{
    public class Klant : IKlantUI
    {
        public string naam { get; set; }
        public int telefoonnummer { get; set; }
        public string emailadres { get; set; }

        IKlantDAL klantDAL = DatabaseFactory.KlantDAL();

        public CadeauKaartInfoDal cadeaukaartinfo = new CadeauKaartInfoDal();
        CadeauKaart Cadeaukaart = new CadeauKaart();
        public List<CadeauKaart> cadeaukaartlijst { get; private set; } = new List<CadeauKaart>();

        public Klant()
        {
        }

        public Klant(string Naam, int Telefoonnummer, string Emailadres)
        {
            naam = Naam;
            telefoonnummer = Telefoonnummer;
            emailadres = Emailadres;
        }

        public void CadeauKaartReserveren(KlantInfoUI klantinfoUI, CadeauKaartInfoUI cadeauKaartinfoUI)
        {
            KlantInfoDal klantinfo = new KlantInfoDal(klantinfoUI.naam, klantinfoUI.telefoonnummer, klantinfoUI.emailadres);
            cadeaukaartinfo = new CadeauKaartInfoDal(cadeauKaartinfoUI.bestemd, cadeauKaartinfoUI.bedrag, klantinfo);

            klantDAL.CadeauKaartReserveren(cadeaukaartinfo);
        }
    }
}
