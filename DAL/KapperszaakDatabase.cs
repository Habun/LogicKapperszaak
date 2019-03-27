using InterfaceDAL;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class KapperszaakDatabase : IKapperszaakDAL
    {
        private SqlCommand cmd;
        private SqlDataReader reader;

        SqlConnection conn = ConnectieDatabase.Connection;

        public List<ProductInfoDal> producten { get; private set; } = new List<ProductInfoDal>()
        {
            new ProductInfoDal("t", "t", 12, "t")
        };
        public List<AfspraakInfoDal> afspraken { get; private set; } = new List<AfspraakInfoDal>();
        public List<CadeauKaartInfoDal> cadeaukaarten { get; private set; } = new List<CadeauKaartInfoDal>();

        public void VerwijderProduct(ProductInfoDal productInfo)
        {
            producten.Remove(productInfo);
        }

        public void VoegProductToe(ProductInfoDal productInfo)
        {
            producten.Add(productInfo);
        }
        public void Inloggen(AdminInfoDal adminInfoDal)
        {
            throw new NotImplementedException();
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
    }
}
