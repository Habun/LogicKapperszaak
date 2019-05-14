using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceDAL
{
    public interface IKapperszaakDAL
    {
        void Inloggen(AdminInfoDal adminInfoDal);
        void VoegProductToe(ProductInfoDal productInfo);
        void VerwijderProduct(int behandelingId);
        List<ProductInfoDal> HaalProductenOp();
        List<AfspraakInfoDal> HaalAfspraakOp();
        List<CadeauKaartInfoDal> HaalCadeauKaartOp();
    }
}
