using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InterfaceUI;
using InterfaceDAL;

namespace LogicKapperszaak
{
    public class Klant : IKlantUI
    {
        public string naam { get; set; }
        public int telefoonnummer { get; set; }
        public string emailadres { get; set; }

        public CadeauKaartInfo cadeaukaartinfo = new CadeauKaartInfo();
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
            KlantInfo klantinfo = new KlantInfo(klantinfoUI.naam, klantinfoUI.telefoonnummer, klantinfoUI.emailadres);
            cadeaukaartinfo = new CadeauKaartInfo(cadeauKaartinfoUI.bestemd, cadeauKaartinfoUI.bedrag, klantinfo);
        }

        public void AfspraakReserveren()
        {
        }
    }
}
