using InterfaceUI;

namespace LogicKapperszaak
{
   public class CadeauKaart
    {
        public string Bestemd { get; set; }
        public decimal Bedrag { get; set; }
        public KlantInfoUI klantInfo { get; set; }

        public CadeauKaart(string bestemd, decimal bedrag, KlantInfoUI klantInfoUI)
        {
            klantInfo = klantInfoUI; 
            Bestemd = bestemd;
            Bedrag = bedrag;
        }

        public CadeauKaart()
        {

        }
    }
}
