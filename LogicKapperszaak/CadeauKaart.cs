using InterfaceUI;

namespace LogicKapperszaak
{
   public class CadeauKaart : ICadeauKaartUi
    {
        public string Bestemd { get;}
        public decimal Bedrag { get;}

        public IKlantUi Klant;
        public CadeauKaart(string bestemd, decimal bedrag, IKlantUi klant)
        {
            Bestemd = bestemd;
            Bedrag = bedrag;
            Klant = klant;
        }

        public CadeauKaart()
        {

        }

        public void UpdateCadeauKaart(ICadeauKaartUi cadeauKaart)
        {

        }
    }
}
