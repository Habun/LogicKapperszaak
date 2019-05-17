

namespace InterfaceDAL
{
    public struct CadeauKaartInfoDal
    {
        public string Bestemd { get;}
        public decimal Bedrag { get;}
        public KlantInfoDal klantinfo { get; }
        
        public CadeauKaartInfoDal(string bestemd, decimal bedrag, KlantInfoDal klantinfoCK)
        {
            klantinfo = klantinfoCK;
            Bestemd = bestemd;
            Bedrag = bedrag;
        }
    }
}
