using InterfaceDAL;
using InterfaceUI;
using FactoryDAL;

namespace LogicKapperszaak
{
   public class CadeauKaart : ICadeauKaartUi
    {
        public string Bestemd { get;}
        public decimal Bedrag { get;}

        public ICadeauKaartDal cadeauKaartDal = DatabaseFactory.CadeauKaartDal();

        private IKlantUi Klant;

        public CadeauKaart(string bestemd, decimal bedrag, IKlantUi klant)
        {
            Bestemd = bestemd;
            Bedrag = bedrag;
            Klant = klant;
        }

        public void UpdateCadeauKaart(ICadeauKaartUi cadeauKaart, IKlantUi klant)
        {
            KlantInfoDal klantInfoDal = new KlantInfoDal(klant.Naam, klant.Telefoonnummer, klant.Emailadres);
            CadeauKaartInfoDal cadeauKaartInfoDal = new CadeauKaartInfoDal(cadeauKaart.Bestemd, cadeauKaart.Bedrag, klantInfoDal);

            cadeauKaartDal.UpdateCadeauKaart(cadeauKaartInfoDal);
        }
    }
}
