using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceUI
{
   public struct KlantInfoUI
    {
        public string naam { get; private set; }
        public int telefoonnummer { get; private set; }
        public string emailadres { get; private set; }

        public KlantInfoUI(string Naam, int Telefoonnummer, string Emailadres)
        {
            naam = Naam;
            telefoonnummer = Telefoonnummer;
            emailadres = Emailadres;
        }
    }
}
