using InterfaceDAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class KapperszaakDatabase : IKapperszaakDAL
    {
        public void VerwijderProduct(ProductInfo productInfo)
        {
            throw new NotImplementedException();
        }

        public void VoegProductToe(ProductInfo productInfo)
        {
            throw new NotImplementedException();
        }
        public void Inloggen()
        {
            throw new NotImplementedException();
        }
        public List<AfspraakInfo> HaalAfspraakOp()
        {
            throw new NotImplementedException();
        }

        public List<CadeauKaartInfo> HaalCadeauKaartOp()
        {
            throw new NotImplementedException();
        }

        public List<ProductInfo> HaalProductenOp()
        {
            throw new NotImplementedException();
        }
    }
}
