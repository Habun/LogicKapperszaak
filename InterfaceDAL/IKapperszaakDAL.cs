using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceDAL
{
    public interface IKapperszaakDAL
    {
        void Inloggen();
        void VoegProductToe(ProductInfo productInfo);
        void VerwijderProduct(ProductInfo productInfo);
        List<ProductInfo> HaalProductenOp();
        List<AfspraakInfo> HaalAfspraakOp();
        List<CadeauKaartInfo> HaalCadeauKaartOp();
    }
}
