

namespace InterfaceDAL
{
    public struct CadeauKaartInfoDal
    {
        public string Bestemd { get;}
        public decimal Bedrag { get;}
        public KlantInfoDal klantDAL { get; }

        public CadeauKaartInfoDal(string bestemd, decimal bedrag, KlantInfoDal klantdal)
        {
            klantDAL = klantdal;
            Bestemd = bestemd;
            Bedrag = bedrag;
        }
    }
}
