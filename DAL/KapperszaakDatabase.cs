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

        public List<AfspraakInfoDal> afspraken { get; private set; } = new List<AfspraakInfoDal>();
        public List<CadeauKaartInfoDal> cadeaukaarten { get; private set; } = new List<CadeauKaartInfoDal>();

        public void VerwijderProduct(ProductInfoDal productInfo)
        {
//            producten.Remove(productInfo);
        }

        public void VoegProductToe(ProductInfoDal productInfo)
        {
  //          producten.Add(productInfo);
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
            List<ProductInfoDal> productenlijst = new List<ProductInfoDal>();

            string query = "Select ProductId, Titel, Omschrijving, Prijs, Image FROM Product"; 

            conn.Open();

            cmd = new SqlCommand(query, conn);
            using (reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    KapperszaakInfoDal kapperszaakInfoDal = new KapperszaakInfoDal(reader.GetInt32(0), reader.GetString(1));
                    ProductInfoDal productInfoDal = new ProductInfoDal(kapperszaakInfoDal,reader.GetString(1), reader.GetString(2), reader.GetDecimal(3), reader.GetString(4));
                    productenlijst.Add(productInfoDal);
                }
                reader.Close();
            }
            conn.Close();

            return productenlijst;
        }
    }
}
