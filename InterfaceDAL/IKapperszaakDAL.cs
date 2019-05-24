using System.Collections.Generic;


namespace InterfaceDAL
{
    public interface IKapperszaakDAL
    {
        void Inloggen(AdminInfoDal adminInfoDal);
        void VoegProductToe(ProductInfoDal productInfo);
        void VerwijderProduct(int behandelingId);
        int GeefProductId(int id);
        void VoegWerknemerToe(WerknemerInfoDal werknemerInfo);
        List<ProductInfoDal> HaalProductenOp();
        List<AfspraakInfoDal> HaalAfspraakOp();
        List<CadeauKaartInfoDal> HaalCadeauKaartOp();
        List<WerknemerInfoDal> HaalWerknemersOp();
    }
}
