

namespace InterfaceUI
{
  public struct KapperszaakinfoUI
    {
        public int Kapperszaakid { get; }
        public string Naam { get; }

        public KapperszaakinfoUI(int kapperszaakId, string naam)
        {
            Kapperszaakid = kapperszaakId;
            Naam = naam;
        }
    }
}
