

namespace InterfaceUI
{
   public struct KlantInfoUI
    {
        public string Naam { get;}
        public int Telefoonnummer { get;}
        public string Emailadres { get;}

        public KlantInfoUI(string naam, int telefoonnummer, string emailadres)
        {
            Naam = naam;
            Telefoonnummer = telefoonnummer;
            Emailadres = emailadres;
        }
    }
}
