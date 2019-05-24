
using InterfaceUI;

namespace LogicKapperszaak
{
  public class Werknemer : IWerknemerUi
    {
        public string Naam { get;}

        public Werknemer()
        {

        }

        public Werknemer(string naam)
        {
            Naam = naam;
        }
    }
}
