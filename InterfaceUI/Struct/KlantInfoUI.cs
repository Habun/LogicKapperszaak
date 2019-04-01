using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceUI
{
   public struct KlantInfoUI
    {
        public string naam { get;}
        public int telefoonnummer { get;}
        public string emailadres { get;}

        public KlantInfoUI(string Naam, int Telefoonnummer, string Emailadres)
        {
            naam = Naam;
            telefoonnummer = Telefoonnummer;
            emailadres = Emailadres;
        }
    }
}
