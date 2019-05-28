using System;
using System.Collections.Generic;
using System.Linq;
using InterfaceDAL;

namespace DAL.Tests
{
    public class KappersZaakContext : IKapperszaakDAL
    {
        public List<ProductInfoDal> producten { get;} = new List<ProductInfoDal>()
        {
            new ProductInfoDal(1, "Haarverf", "zwart", "lol.jpg")
        };
        public List<CadeauKaartInfoDal> cadeaukaarten { get;} = new List<CadeauKaartInfoDal>();
        public List<WerknemerInfoDal> werknemers { get;} = new List<WerknemerInfoDal>();
        public List<AfspraakInfoDal> afspraken { get;} = new List<AfspraakInfoDal>();

        public void Inloggen(AdminInfoDal adminInfoDal)
        {
            string emailadres = "habun@live.nl";
            string wachtwoord = "test12";

            if (adminInfoDal.Emailadres == emailadres)
            {
                if (adminInfoDal.Wachtwoord == wachtwoord)
                {

                }
            }
        }

        public void VerwijderProduct(int productId)
        {
            throw new NotImplementedException();
        }

        public void VoegProductToe(ProductInfoDal productInfo)
        {
            producten.Add(productInfo);
        }

        public void VoegWerknemerToe(WerknemerInfoDal werknemerInfo)
        {
            werknemers.Add(werknemerInfo);
        }

        public List<AfspraakInfoDal> HaalAfspraakOp()
        {
            return afspraken;
        }

        public List<CadeauKaartInfoDal> HaalCadeauKaartOp()
        {
            return cadeaukaarten;
        }

        public List<ProductInfoDal> HaalProductenOp()
        {
            return producten;
        }

        public List<WerknemerInfoDal> HaalWerknemersOp()
        {
            return werknemers;
        }
    }
}
