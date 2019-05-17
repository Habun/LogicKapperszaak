

namespace InterfaceDAL
{
    public struct KlantInfoDal
    {
        public string Naam { get;}
        public int Telefoonnummer { get;}
        public string Emailadres { get;}

        public KlantInfoDal(string naam, int telefoonnummer, string emailadres)
        {
            Naam = naam;
            Telefoonnummer = telefoonnummer;
            Emailadres = emailadres;
        }
    }
}
