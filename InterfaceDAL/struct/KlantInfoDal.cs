using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceDAL
{
    public struct KlantInfoDal
    {
        public string naam { get; private set; }
        public int telefoonnummer { get; private set; }
        public string emailadres { get; private set; }

        public KlantInfoDal(string Naam, int Telefoonnummer, string Emailadres)
        {
            naam = Naam;
            telefoonnummer = Telefoonnummer;
            emailadres = Emailadres;
        }
    }
}
