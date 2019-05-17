

namespace InterfaceUI
{
   public struct CadeauKaartInfoUI
    {
        public string Bestemd { get;}
        public decimal Bedrag { get;}
        public KlantInfoUI klantinfo { get;}

        public CadeauKaartInfoUI(string bestemd, decimal bedrag, KlantInfoUI klantinfoCK)
        {
            klantinfo = klantinfoCK;
            Bestemd = bestemd;
            Bedrag = bedrag;
        }
    }
}
