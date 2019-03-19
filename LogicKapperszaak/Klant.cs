using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicKapperszaak
{
    public class Klant
    {
        public string naam { get; set; }
        public int telefoonnummer { get; set; }
        public string emailadres { get; set; }

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

        public void CadeauKaartReserveren(string Naam, int Telefoonnummer, string Emailadres, CadeauKaart cadeauKaart)
        {
            naam = Naam;
            telefoonnummer = Telefoonnummer;
            emailadres = Emailadres;
            cadeauKaart.bestemd = cadeauKaart.bestemd;
            cadeauKaart.bedrag = cadeauKaart.bedrag; 
        }

        public void AfspraakReserveren()
        {
        }
    }
}
