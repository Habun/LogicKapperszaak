

namespace InterfaceDAL
{
   public struct KapperszaakInfoDal
    {
        public int Kapperszaakid { get; }
        public string Naam { get; }

        public KapperszaakInfoDal(int kapperszaakId, string naam)
        {
            Kapperszaakid = kapperszaakId;
            Naam = naam;
        }
    }
}
