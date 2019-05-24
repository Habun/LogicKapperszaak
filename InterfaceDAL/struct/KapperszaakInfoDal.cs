

namespace InterfaceDAL
{
   public struct KapperszaakInfoDal
    {
        public int Id { get; }
        public string Naam { get; }

        public KapperszaakInfoDal(int id, string naam)
        {
            Id = id;
            Naam = naam;
        }
    }
}
