using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceDAL
{
    public struct KlantInfoDal
    {
        public string naam { get;}
        public int telefoonnummer { get;}
        public string emailadres { get;}

        public KlantInfoDal(string Naam, int Telefoonnummer, string Emailadres)
        {
            naam = Naam;
            telefoonnummer = Telefoonnummer;
            emailadres = Emailadres;
        }
    }
}
